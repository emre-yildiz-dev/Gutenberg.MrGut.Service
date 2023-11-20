using Abp.Domain.Entities.Auditing;
using GutenBerg.MrGut.Domain.Authors;
using GutenBerg.MrGut.Domain.Genres;

namespace GutenBerg.MrGut.Domain.Books;

public class Book: FullAuditedEntity
{
    public int BookId { get; set; }
    public string Title { get; set; }
    public int? PublicationYear { get; set; }
    public string Language { get; set; }
    public string Content { get; set; }

    // Foreign keys
    public int AuthorId { get; set; }
    public int GenreId { get; set; }

    // Navigation properties
    public Author Author { get; set; }
    public Genre Genre { get; set; }
}
