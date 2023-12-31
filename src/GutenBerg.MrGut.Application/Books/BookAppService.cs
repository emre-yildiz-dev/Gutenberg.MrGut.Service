using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using GutenBerg.MrGut.Domain.Books;
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

    public async Task<PagedResultDto<BookPageDto>> GetPaginatedBookPagesAsync(BookPagesRequestDto input)
    {
        return await _bookManager.GetPaginatedBookPagesAsync(input);
    }

    public async Task<MemoizedPageDto> GetUserBookMapping(MemoizedPageDto pageDto)
    {
        return await _bookManager.GetUserBookMapping(AbpSession.UserId, pageDto.GutenbergId);
    }
    public async Task<UserBookMapping> PostUserBookMapping(MemoizedPageDto pageDto)
    {
        return await _bookManager.PostUserBookMapping(AbpSession.UserId, pageDto);
    }
}