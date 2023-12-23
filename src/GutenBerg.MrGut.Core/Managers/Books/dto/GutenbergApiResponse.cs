using System.Collections.Generic;

namespace GutenBerg.MrGut.Managers.Books.dto;

public class GutenbergApiResponse
{
    public List<BookResult> Results { get; set; }
    public int TotalCount { get; set; }
    // Other properties
}

