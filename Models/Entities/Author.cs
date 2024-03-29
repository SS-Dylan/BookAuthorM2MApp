﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookAuthorM2MApp.Models.Entities;

public class Author
{
    public int Id { get; set; }
    [StringLength(128)]
    public string? FirstName { get; set; } = string.Empty;
    [Required, StringLength(128)]
    public string LastName { get; set; } = string.Empty;
    [DisplayName("Number of Books")]
    public ICollection<Book> Books { get; set; } = new List<Book>();
}
