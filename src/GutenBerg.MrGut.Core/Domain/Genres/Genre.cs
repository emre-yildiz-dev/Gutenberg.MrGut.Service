using System.Collections.Generic;
using Abp.Domain.Entities;
using GutenBerg.MrGut.Domain.Books;

namespace GutenBerg.MrGut.Domain.Genres;

public class Genre: Entity
{
    public int GenreId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    // Navigation property
    public ICollection<Book> Books { get; set; }
}
