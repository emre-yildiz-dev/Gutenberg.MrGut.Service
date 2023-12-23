using System.Collections.Generic;
using System.Threading.Tasks;
using GutenBerg.MrGut.Managers;
using GutenBerg.MrGut.Managers.Books;
using GutenBerg.MrGut.Managers.Books.dto;

namespace GutenBerg.MrGut.Books;

public class BookAppService: MrGutAppServiceBase
{
    private readonly IBookManager _bookManager;

    public BookAppService(IBookManager bookManager)
    {
        _bookManager = bookManager;
    }

    public async Task<List<BookDto>> GetBooks()
    {
        return await _bookManager.GetBooksAsync();
    }

    public async Task<BookDto> GetBookById(int id)
    {
        return await _bookManager.GetBookByIdAsync(id);
    }

}