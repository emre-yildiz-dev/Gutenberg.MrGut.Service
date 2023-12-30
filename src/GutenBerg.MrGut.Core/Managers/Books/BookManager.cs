using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
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
using HtmlAgilityPack;

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
            .Where(book => book.Formats.TryGetValue("text/html", out var _))
            .Where(book => book.Formats.TryGetValue("image/jpeg", out var _))
            .Select(book => new BookDto
            {
                Id = book.Id,
                Title = book.Title,
                Author = string.Join(", ", book.Authors.Select(a => a.Name)),
                Languages = string.Join(", ", book.Languages.Select(s => s)),
                ImageUrl = book.Formats["image/jpeg"],
                ContentUrl = book.Formats["text/html"]
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
            ImageUrl = book.Formats["image/jpeg"],
            ContentUrl = book.Formats["text/html"]
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
            Languages = bookDto.Languages,
            AuthorId = authorSaveResult.Id
        };
        var bookExists = _bookStore.BookExists(bookDto.Id);
        if (bookExists) return bookDto;
        var bookSaveResult = await _bookStore.CreateAsync(bookToSave);
        await _unitOfWorkManager.Current.SaveChangesAsync();
        var htmlContent = await GetBookHtmlContent(bookDto.ContentUrl);
        var pages = SplitHtmlByH2Tags(htmlContent);
        var pagesWithHeader = SplitHtmlContent(htmlContent);
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


    public List<string> SplitHtmlByH2Tags(string htmlContent)
    {
        var doc = new HtmlDocument();
        doc.LoadHtml(htmlContent);

        var pages = new List<string>();
   
        var currentPageContent = "";

        foreach (var node in doc.DocumentNode.Descendants())
        {
            if (node.Name == "h2" && !string.IsNullOrWhiteSpace(currentPageContent))
            {
                // Start a new page
                pages.Add(currentPageContent);
                currentPageContent = "";
            }
            currentPageContent += node.OuterHtml;
        }

        // Add the last page if it has content
        if (!string.IsNullOrWhiteSpace(currentPageContent))
        {
            pages.Add(currentPageContent);
        }
        var adjustedPages = pages.Select((page, index) => 
        {
            if (index == 0)
            {
                // Remove DOCTYPE and wrap in a div
                return "<div>" + Regex.Replace(page, "<!DOCTYPE html[^>]*>", "", RegexOptions.IgnoreCase) + "</div>";
            }
            else
            {
                // Wrap in a div if not already wrapped
                return page.StartsWith("<div>") ? page : "<div>" + page + "</div>";
            }
        }).ToList();
        
        return adjustedPages;
    }

    private class PageContent
    {
        public string Header { get; set; }
        public List<string> Pages { get; set; }
    }

    private List<string> SplitHtmlContent(string htmlContent)
    {
        var doc = new HtmlDocument();
        doc.LoadHtml(htmlContent);

        var pageContent = new PageContent
        {
            Pages = new List<string>()
        };

        var bodyBuilder = new StringBuilder();
        var headerExtracted = false;

        foreach (var node in doc.DocumentNode.Descendants())
        {
            if (!headerExtracted && node.Name != "h2")
            {
                pageContent.Header += node.OuterHtml;
            }
            else
            {
                if (node.Name == "h2" && bodyBuilder.Length > 0)
                {
                    // Add the current page to the list and start a new page
                    pageContent.Pages.Add(bodyBuilder.ToString());
                    bodyBuilder.Clear();
                }
                headerExtracted = true;
                bodyBuilder.Append(node.OuterHtml);
            }
        }
        
        // Add the last page if it has content
        if (bodyBuilder.Length <= 0) return pageContent.Pages;
        pageContent.Pages.Add(pageContent.Header);
        pageContent.Pages.Add(bodyBuilder.ToString());

        return pageContent.Pages;
    }
}