using System.Collections.Generic;
using GutenBerg.MrGut.Domain.Authors;

namespace GutenBerg.MrGut.Managers.Books.dto;

public class BookResult
{
    public string Title { get; set; }
    public List<Author> Authors { get; set; }
    public Dictionary<string, string> Formats { get; set; }
}