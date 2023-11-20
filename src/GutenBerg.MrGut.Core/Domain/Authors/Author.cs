using System.Collections.Generic;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using GutenBerg.MrGut.Domain.Books;

namespace GutenBerg.MrGut.Domain.Authors;

public class Author: Entity
{
    public string Name { get; set; }
    public int? BirthYear { get; set; }
    public int? DeathYear { get; set; }
    public string Nationality { get; set; }

    // Navigation property
    public ICollection<Book> Books { get; set; }
}
