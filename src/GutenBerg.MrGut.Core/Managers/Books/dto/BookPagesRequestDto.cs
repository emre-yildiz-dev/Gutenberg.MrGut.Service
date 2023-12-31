using Abp.Application.Services.Dto;

namespace GutenBerg.MrGut.Managers.Books.dto;

public class BookPagesRequestDto: IPagedAndSortedResultRequest
{
    public int BookId { get; set; }
    public int GutenbergId { get; set; }
    public int MaxResultCount { get; set; }
    public int SkipCount { get; set; }
    public string Sorting { get; set; }
}