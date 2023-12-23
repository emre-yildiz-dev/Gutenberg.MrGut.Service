using JetBrains.Annotations;

namespace GutenBerg.MrGut.Managers.Books.dto;

public class BookDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string ImageUrl { get; set; }
    [CanBeNull] public string ContentUrl { get; set; }
    public string Languages { get; set; }
}
