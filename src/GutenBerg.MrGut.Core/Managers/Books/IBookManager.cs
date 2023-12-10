using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Domain.Services;
using GutenBerg.MrGut.Managers.Books.dto;

namespace GutenBerg.MrGut.Managers.Books;

public interface IBookManager: IDomainService
{
    Task<List<BookDto>> GetBooksAsync();
}