using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using GutenBerg.MrGut.Domain.Books;
using GutenBerg.MrGut.Managers.Books.dto;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace GutenBerg.MrGut.Managers.Books;

public class BookManager: BaseManager, IBookManager
{
    private readonly HttpClient _httpClient;

    public BookManager(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<PagedResultDto<BookDto>> GetBooksAsync(int pageNumber = 1, int pageSize = 10, string searchTerm = "")
    {
        var response = await _httpClient.GetAsync(
            $"http://gutendex.com/books?search={WebUtility.UrlEncode(searchTerm)}&page={pageNumber}&limit={pageSize}");
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<GutenbergApiResponse>(content);

        var books = result.Results
            .Where(book => book.Formats.TryGetValue("text/html", out var _)).Where(book => book.Formats.TryGetValue("image/jpeg", out var _))
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
        
        return  new BookDto
        {
            Id = book.Id,
            Title = book.Title,
            Author = string.Join(", ", book.Authors.Select(a => a.Name)),
            Languages = string.Join(", ", book.Languages.Select(s => s)),
            ImageUrl = book.Formats["image/jpeg"],
            ContentUrl = book.Formats["text/html"]
        };
    }
}