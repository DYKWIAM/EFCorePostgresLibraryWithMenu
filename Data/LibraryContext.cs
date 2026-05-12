using Microsoft.EntityFrameworkCore;
using LibrarySystem.Models;

namespace LibrarySystem.Data;

public class LibraryContext : DbContext
{
    public DbSet<Author> Authors => Set<Author>();
    public DbSet<Book> Books { get; set; }
    public DbSet<Category> Categories => Set<Category>();
    public DbSet<BookCategory> BookCategories => Set<BookCategory>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(
            "Host=localhost;Port=5432;Database=librarydb;Username=postgres;Password=asdasd"
        );
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Composite key for many-to-many with Book and Category
        modelBuilder.Entity<BookCategory>()
            .HasKey(bc => new { bc.BookId, bc.CategoryId });

        // Unique constraint
        modelBuilder.Entity<Author>()
            .HasIndex(a => a.Email)
            .IsUnique();

        // Seed Authors
        modelBuilder.Entity<Author>().HasData(
           new Author { Id = 1, Name = "J.K. Rowling", Email = "jk@example.com" },
            new Author { Id = 2, Name = "George Orwell", Email = "orwell@example.com" },
            new Author { Id = 3, Name = "Jane Austen", Email = "austen@example.com" },
            new Author { Id = 4, Name = "Mark Twain", Email = "twain@example.com" },
            new Author { Id = 5, Name = "Ernest Hemingway", Email = "hemingway@example.com" },
            new Author { Id = 6, Name = "F. Scott Fitzgerald", Email = "fitzgerald@example.com" },
            new Author { Id = 7, Name = "Agatha Christie", Email = "christie@example.com" },
            new Author { Id = 8, Name = "J.R.R. Tolkien", Email = "tolkien@example.com" },
            new Author { Id = 9, Name = "Stephen King", Email = "sking@example.com" },
            new Author { Id = 10, Name = "Haruki Murakami", Email = "murakami@example.com" },
            new Author { Id = 11, Name = "Leo Tolstoy", Email = "tolstoy@example.com" },
            new Author { Id = 12, Name = "Virginia Woolf", Email = "vwoolf@example.com" }
        );
        // the rest of Seed was moved afterwards to LibrarySeedData to keep Context clean and short.
        // so here we just call the list from LibrarySeedData.cs Class.
        // this is because i wanted to have a little bit more data to show.
        modelBuilder.Entity<Book>().HasData(LibrarySeedData.Books);
        modelBuilder.Entity<Category>().HasData(LibrarySeedData.Categories);
        modelBuilder.Entity<BookCategory>().HasData(LibrarySeedData.BookCategories);
    }
}