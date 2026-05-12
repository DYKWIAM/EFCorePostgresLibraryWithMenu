using System.ComponentModel.DataAnnotations;

namespace LibrarySystem.Models;

public class Book
{
    public int Id { get; set; }

    [Required]
    [MaxLength(70)]
    public string Title { get; set; } = string.Empty;

    [Required]
    [MaxLength(10)]
    public string ISBN { get; set; } = string.Empty;

    public int PublishedYear { get; set; }

    // Foreign Key
    public int AuthorId { get; set; }

    // Navigation Property
    public Author? Author { get; set; }

    // Many-to-Many
    public List<BookCategory> BookCategories { get; set; } = new();
}