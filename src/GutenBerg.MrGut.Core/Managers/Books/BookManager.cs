using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using GutenBerg.MrGut.Managers.Books.dto;
using Newtonsoft.Json;

namespace GutenBerg.MrGut.Managers.Books;

public class BookManager: BaseManager, IBookManager
{
    private readonly HttpClient _httpClient;

    public BookManager(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<BookDto>> GetBooksAsync()
    {
        var response = await _httpClient.GetAsync("http://gutendex.com/books");
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<GutenbergApiResponse>(content);

        // Convert the response to a list of BookDto objects
        return result.Results.Select(book => new BookDto
        {
            Title = book.Title,
            Author = string.Join(", ", book.Authors.Select(a => a.Name)),
            ImageUrl = book.Formats["image/jpeg"] // or the correct key for the image
        }).ToList();
    }
}