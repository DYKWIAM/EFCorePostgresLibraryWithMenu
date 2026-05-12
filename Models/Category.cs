using System.ComponentModel.DataAnnotations;

namespace LibrarySystem.Models;

public class Category
{
    public int Id { get; set; }

    [Required]
    [MaxLength(50)]
    public string Name { get; set; } = string.Empty;

    // Many-to-Many we use List<T>
    public List<BookCategory> BookCategories { get; set; } = new();
}