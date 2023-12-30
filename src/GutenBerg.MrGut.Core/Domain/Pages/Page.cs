using Abp.Domain.Entities;
using GutenBerg.MrGut.Domain.Books;

namespace GutenBerg.MrGut.Domain.Pages;

public class Page: Entity
{
    public int Id { get; set; }
    public string Content { get; set; }
    public int BookId { get; set; }
    public Book Book { get; set; }
}
