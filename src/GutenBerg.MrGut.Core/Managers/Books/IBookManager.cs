using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Services;
using GutenBerg.MrGut.Managers.Books.dto;
using JetBrains.Annotations;

namespace GutenBerg.MrGut.Managers.Books;

public interface IBookManager: IDomainService
{
Task<PagedResultDto<BookDto>> GetBooksAsync(int pageNumber = 1, int pageSize = 10, string searchTerm = "");
    Task<BookDto> GetBookByIdAsync(int id);
    Task<PagedResultDto<BookDto>> GetUserBooksAsync(int pageNumber, int pageSize, string searchTerm, long? abpSessionUserId);
    Task<PagedResultDto<BookPageDto>> GetPaginatedBookPagesAsync(BookPagesRequestDto input);
}