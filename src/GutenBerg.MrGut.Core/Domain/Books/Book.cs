using System.Collections.ObjectModel;
using Abp.Domain.Entities.Auditing;
using GutenBerg.MrGut.Domain.Authors;
using GutenBerg.MrGut.Domain.Pages;

namespace GutenBerg.MrGut.Domain.Books;

public class Book: FullAuditedEntity
{
    public int GutenbergId { get; set; }
    public string Title { get; set; }
    public string Languages { get; set; }
    public string Content { get; set; }
    public string ContentUrl { get; set; }

    public int AuthorId { get; set; }

    public Author Author { get; set; }
    public Collection<Page> Page { get; set; }
    public string ImageUrl { get; set; }
}
