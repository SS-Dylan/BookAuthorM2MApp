using System.ComponentModel.DataAnnotations;

namespace BookAuthorM2MApp.Models.Entities;

public class Author
{
    public int Id { get; set; }
    [StringLength(128)]
    public string? FirstName { get; set; } = string.Empty;
    [Required, StringLength(128)]
    public string LastName { get; set; } = string.Empty;

    public ICollection<BookAuthor> BookAuthors { get; set; } = new List<BookAuthor>();
}
