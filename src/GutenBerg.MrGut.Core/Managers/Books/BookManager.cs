using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Uow;
using GutenBerg.MrGut.Domain.Authors;
using GutenBerg.MrGut.Domain.Books;
using GutenBerg.MrGut.Domain.Pages;
using GutenBerg.MrGut.Managers.Books.dto;
using GutenBerg.MrGut.Stores.Authors;
using GutenBerg.MrGut.Stores.Books;
using GutenBerg.MrGut.Stores.Pages;
using GutenBerg.MrGut.Stores.UserBookMappings;
using Newtonsoft.Json;

namespace GutenBerg.MrGut.Managers.Books;

public class BookManager : BaseManager, IBookManager
{
    private readonly HttpClient _httpClient;
    private readonly IBookStore _bookStore;
    private readonly IAuthorStore _authorStore;
    private readonly IPageStore _pageStore;
    private readonly IUserBookMappingStore _userBookMappingStore;
    private readonly IUnitOfWorkManager _unitOfWorkManager;

    public BookManager(HttpClient httpClient, IBookStore bookStore, IAuthorStore authorStore,
        IUserBookMappingStore userBookMappingStore, IUnitOfWorkManager unitOfWorkManager, IPageStore pageStore)
    {
        _httpClient = httpClient;
        _bookStore = bookStore;
        _authorStore = authorStore;
        _userBookMappingStore = userBookMappingStore;
        _unitOfWorkManager = unitOfWorkManager;
        _pageStore = pageStore;
    }

    public async Task<PagedResultDto<BookDto>> GetBooksAsync(int pageNumber = 1, int pageSize = 10,
        string searchTerm = "")
    {
        var response = await _httpClient.GetAsync(
            $"http://gutendex.com/books?search={WebUtility.UrlEncode(searchTerm)}&page={pageNumber}&limit={pageSize}");
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<GutenbergApiResponse>(content);

        var books = result.Results
            .Where(book => book.Formats.TryGetValue("text/plain; charset=us-ascii", out var _))
            .Where(book => book.Formats.TryGetValue("image/jpeg", out var _))
            .Select(book => new BookDto
            {
                Id = book.Id,
                Title = book.Title,
                Author = string.Join(", ", book.Authors.Select(a => a.Name)),
                Languages = string.Join(", ", book.Languages.Select(s => s)),
                ImageUrl = book.Formats["image/jpeg"],
                ContentUrl = book.Formats["text/plain; charset=us-ascii"]
            }).ToList();

        return new PagedResultDto<BookDto>
        {
            Items = books,
            TotalCount = result.TotalCount // Or fetch the total count if not provided
        };
    }

    public async Task<BookDto> GetBookByIdAsync(int id)
    {
        var response = await _httpClient.GetAsync("http://gutendex.com/books/" + id);
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();
        var book = JsonConvert.DeserializeObject<BookResult>(content);

        
        
        var bookDto = new BookDto
        {
            Id = book.Id,
            Title = book.Title,
            Author = string.Join(", ", book.Authors.Select(a => a.Name)),
            Languages = string.Join(", ", book.Languages.Select(s => s)),
            ImageUrl = book.Formats.ContainsKey("image/jpeg") 
                ? book.Formats["image/jpeg"] 
                :"https://cdn.pixabay.com/photo/2018/01/17/18/43/book-3088775_1280.jpg",
            ContentUrl = book.Formats.ContainsKey("text/plain; charset=us-ascii")  
                ? book.Formats["text/plain; charset=us-ascii"]
                : "No content !"
        };
      

        var author = new Author
        {
            Name = bookDto.Author,
            BirthYear = book.Authors.Select(a => a.BirthYear).FirstOrDefault(),
            DeathYear = book.Authors.Select(a => a.DeathYear).FirstOrDefault(),
        };

        var authorExists = _authorStore.AuthorExists(author.Name);
        if (authorExists) return bookDto;
        var authorSaveResult = await _authorStore.CreateAsync(author);
        await _unitOfWorkManager.Current.SaveChangesAsync();

        var bookToSave = new Book
        {
            GutenbergId = bookDto.Id,
            Title = bookDto.Title,
            ContentUrl = bookDto.ContentUrl,
            ImageUrl = bookDto.ImageUrl,
            Languages = bookDto.Languages,
            AuthorId = authorSaveResult.Id
        };
        var bookExists = _bookStore.BookExists(bookDto.Id);
        if (bookExists) return bookDto;
        var bookSaveResult = await _bookStore.CreateAsync(bookToSave);
        await _unitOfWorkManager.Current.SaveChangesAsync();
        var textContent = await GetBookHtmlContent(bookDto.ContentUrl);
        
       const int paragraphsPerPage = 18;
       
        var pages = ConvertToHtmlPages(textContent, paragraphsPerPage);
        for (int i = 0; i < pages.Count; i++)
        {
            var pageToSave = new Page
            {
                BookId = bookSaveResult.Id,
                GutenbergId = bookToSave.GutenbergId,
                Content = pages[i],
                PageNumber = i+1
            };
            await _pageStore.CreateAsync(pageToSave); 
        } 
      

        var userBookMapping = new UserBookMapping
        {
            BookId = bookSaveResult.Id,
            UserId = AbpSession.UserId
        };
        var existedBook = _bookStore.GetList(book1 => book1.GutenbergId == bookToSave.GutenbergId)
            .FirstOrDefault();
        var userBookMappingExists =
            existedBook != null &&
            _userBookMappingStore.UserBookMappingExists(existedBook.Id, userBookMapping.UserId);
        if (userBookMappingExists)
            return bookDto;
        await _userBookMappingStore.CreateAsync(userBookMapping);

        return bookDto;
    }

    public async Task<PagedResultDto<BookDto>> GetUserBooksAsync(int pageNumber, int pageSize, string searchTerm, long? abpSessionUserId)
    {
        var bookIdList = _userBookMappingStore
            .GetList(mapping => mapping.UserId == abpSessionUserId)
            .Select(mapping => mapping.BookId).ToList();

        var query = _bookStore.GetList(book => bookIdList.Contains(book.Id) && (string.IsNullOrEmpty(searchTerm) || book.Title.Contains(searchTerm)));

        var booksPage = query.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();

        var bookDtos = booksPage.Select(book => MapToBookDto(book, _authorStore)).ToList();

        var totalCount = query.Count();

        return new PagedResultDto<BookDto>
        {
            Items = bookDtos,
            TotalCount = totalCount
        };
    }

    public Task<PagedResultDto<BookPageDto>> GetPaginatedBookPagesAsync(BookPagesRequestDto input)
    {
        // Validate input parameters
        if (input.MaxResultCount <= 0 || input.SkipCount < 0)
        {
            throw new ArgumentException("Invalid pagination parameters");
        }

        // Filter the pages based on GutenbergId
        var filteredPages = _pageStore.GetList(page => page.GutenbergId == input.GutenbergId);

        // Apply pagination
        var paginatedPages = filteredPages
            .Skip(input.SkipCount)
            .Take(input.MaxResultCount)
            .ToList();

        var totalCount = filteredPages.Count();

        // Map the result to BookPageDto
        var bookPageDtos = paginatedPages.Select(page => new BookPageDto
        {
            GutenbergId = page.GutenbergId,
            BookId = page.BookId,
            Content = page.Content,
            PageNumber = page.PageNumber
        }).ToList();
        
        // Return the paginated result
        return Task.FromResult(new PagedResultDto<BookPageDto>(totalCount, bookPageDtos));
    }



    private BookDto MapToBookDto(Book book, IAuthorStore authorStore)
    {
     
        var bookDto =  new BookDto
        {
            Id = book.Id,
            GutenbergId = book.GutenbergId,
            Title = book.Title,
            Languages = book.Languages,
            ContentUrl = book.ContentUrl,
            Content = book.Content,
            ImageUrl = book.ImageUrl
        };
        var author = authorStore.GetList(author1 => author1.Id == book.AuthorId).FirstOrDefault();
        if (author is not null)
        {
            bookDto.Author = author.Name;
        }
        return bookDto;
    }

    private async Task<string> GetBookHtmlContent(string contentUrl)
    {
        using var client = new HttpClient();
        var response = await client.GetAsync(contentUrl, HttpCompletionOption.ResponseHeadersRead);
        if (response.StatusCode == System.Net.HttpStatusCode.Found) // 302 Found
        {
            if (response.Headers.Location == null) return await response.Content.ReadAsStringAsync();
            var redirectedUrl = response.Headers.Location.ToString();
            Console.WriteLine("Redirected URL: " + redirectedUrl);

            // Optionally, you can now fetch the content from the redirected URL
            var redirectedResponse = await client.GetAsync(redirectedUrl);
            redirectedResponse.EnsureSuccessStatusCode();

            var htmlContent = await redirectedResponse.Content.ReadAsStringAsync();

            //response.EnsureSuccessStatusCode();
            return htmlContent;
        }

        return "";
    }


    private class PageContent
    {
        public string Header { get; set; }
        public List<string> Pages { get; set; }
    }

  
    public static List<string> SplitTextIntoPages(string text, int wordLimit)
    {
        var pages = new List<string>();
        var words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var currentPage = new List<string>();
        var currentWordCount = 0;

        foreach (var word in words)
        {
            currentPage.Add(word);
            currentWordCount++;

            // Check if the current word ends with a period and we've reached the word limit
            if (word.EndsWith(".") && currentWordCount >= wordLimit)
            {
                pages.Add(string.Join(" ", currentPage));
                currentPage.Clear();
                currentWordCount = 0;
            }
        }

        // Add the last page if it has content
        if (currentPage.Count > 0)
        {
            pages.Add(string.Join(" ", currentPage));
        }

        return pages;
    }
    public static List<string> SplitTextIntoHtmlPages(string text, int wordLimit)
    {
        var pages = new List<string>();
        var paragraphs = text.Split(new[] { "\n\n" }, StringSplitOptions.RemoveEmptyEntries);
        var currentPage = new List<string>();
        var currentWordCount = 0;

        foreach (var paragraph in paragraphs)
        {
            var words = paragraph.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in words)
            {
                currentPage.Add(word);
                currentWordCount++;

                if (!word.EndsWith(".") || currentWordCount < wordLimit) continue;
                pages.Add($"<p>{string.Join(" ", currentPage)}</p>");
                currentPage.Clear();
                currentWordCount = 0;
            }

            // Check if the paragraph ends and add it to the current page
            if (currentPage.Count > 0)
            {
                currentPage.Add("<br>"); // Adds a line break between paragraphs
            }
        }

        // Add the last page if it has content
        if (currentPage.Count > 0)
        {
            pages.Add($"<p>{string.Join(" ", currentPage)}</p>");
        }

        return pages;
    }
    public static List<string> ConvertToHtmlPages(string rawText, int paragraphsPerPage = 8)
    {
        List<string> htmlPages = new List<string>();
        string[] paragraphs = rawText.Split(new string[] { "\r\n\r\n", "\n\n" }, StringSplitOptions.None);

        StringBuilder htmlBuilder = new StringBuilder();
        int paragraphCountOnCurrentPage = 0;
        int currentPage = 1;  // Initialize page number for correct tracking

        foreach (string paragraph in paragraphs)
        {
            // Apply HTML encoding and formatting
            string escapedParagraph = System.Web.HttpUtility.HtmlEncode(paragraph);
            htmlBuilder.Append("<p>");
            htmlBuilder.Append(escapedParagraph);
            htmlBuilder.Append("</p>");

            paragraphCountOnCurrentPage++;

            if (paragraphCountOnCurrentPage < paragraphsPerPage) continue;
            // Complete the current page and add it to the list
            htmlBuilder.Append("<p style=\"text-align: center;\">Page " + currentPage + " of " + ((paragraphs.Length + paragraphsPerPage - 1) / paragraphsPerPage) + "</p>");
            htmlPages.Add(htmlBuilder.ToString());
            htmlBuilder = new StringBuilder(); // Reset for the next page
            paragraphCountOnCurrentPage = 0; // Reset paragraph count
            currentPage++;  // Increment page number for the next page
        }

        // Add any remaining content as the last page
        if (htmlBuilder.Length <= 0) return htmlPages;
        htmlBuilder.Append("<p style=\"text-align: center;\">Page " + currentPage + " of " + ((paragraphs.Length + paragraphsPerPage - 1) / paragraphsPerPage) + "</p>");
        htmlPages.Add(htmlBuilder.ToString());

        return htmlPages;
    }


}