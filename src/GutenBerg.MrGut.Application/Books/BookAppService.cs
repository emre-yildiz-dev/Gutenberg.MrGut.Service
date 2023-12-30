using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
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

    public async Task<PagedResultDto<BookDto>> GetBooks(int pageNumber, int pageSize, string searchTerm)
    {
        return await _bookManager.GetBooksAsync(pageNumber, pageSize, searchTerm);
    }
    public async Task<PagedResultDto<BookDto>> GetUserBooks(int pageNumber, int pageSize, string searchTerm)
    {
        return await _bookManager.GetUserBooksAsync(pageNumber, pageSize, searchTerm, AbpSession.UserId);
    }


    public async Task<BookDto> GetBookById(int id)
    {
        return await _bookManager.GetBookByIdAsync(id);
    }
}