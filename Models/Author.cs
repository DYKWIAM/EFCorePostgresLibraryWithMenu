using System.ComponentModel.DataAnnotations;

namespace LibrarySystem.Models;

public class Author
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;

    [Required]
    [MaxLength(100)]
    public string Email { get; set; } = string.Empty;

    // 1 Author -> Many Books
    public List<Book> Books { get; set; } = new();
}