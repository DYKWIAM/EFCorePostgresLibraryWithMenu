using LibrarySystem.Data;
using LibrarySystem.Models;
using Microsoft.EntityFrameworkCore;

namespace LibrarySystem.Services;

public class LibraryService
{
    private readonly LibraryContext _context;

    public LibraryService()
    {
        _context = new LibraryContext();
    }

    // CREATE
    public void AddBook()
    {
        Console.Write("Title: ");
        string title = Console.ReadLine()!;

        Console.Write("ISBN: ");
        string isbn = Console.ReadLine()!;

        Console.Write("Year: ");
        int year = int.Parse(Console.ReadLine()!);

        Console.Write("Author Id: ");
        int authorId = int.Parse(Console.ReadLine()!);

        var book = new Book
        {
            Title = title,
            ISBN = isbn,
            PublishedYear = year,
            AuthorId = authorId
        };

        _context.Books.Add(book);
        _context.SaveChanges();

        Console.WriteLine("Book added.");
    }

    // READ with include.
    public void ShowBooks()
    {
        var books = _context.Books
            .Include(b => b.Author)
            .Include(b => b.BookCategories)
                .ThenInclude(bc => bc.Category)
            .ToList();

        foreach (var readBook in books)
        {
            Console.WriteLine("----------------");

            Console.WriteLine($"Id: {readBook.Id}");
            Console.WriteLine($"Title: {readBook.Title}");
            Console.WriteLine($"Author: {readBook.Author?.Name}");

            foreach (var bc in readBook.BookCategories)
            {
                Console.WriteLine($"Category: {bc.Category?.Name}");
            }
        }
    }

    // UPDATE
    public void UpdateBook()
    {
        Console.Write("Book Id: ");
        int id = int.Parse(Console.ReadLine()!);

        var book = _context.Books.Find(id);

        if (book == null)
        {
            Console.WriteLine("Book not found.");
            return;
        }

        Console.Write("New title: ");
        book.Title = Console.ReadLine()!;

        _context.SaveChanges();

        Console.WriteLine("Book updated.");
    }

    // DELETE
    public void DeleteBook()
    {
        Console.Write("Book Id: ");
        int id = int.Parse(Console.ReadLine()!);

        var book = _context.Books.Find(id);

        if (book == null)
        {
            Console.WriteLine("Book not found.");
            return;
        }

        _context.Books.Remove(book);

        _context.SaveChanges();

        Console.WriteLine("Book deleted.");
    }

    // At least one operation that manages relationships (e.g., adding a category to a book).
    public void AddCategoryToBook()
    {
        Console.Write("Book Id: ");
        int bookId = int.Parse(Console.ReadLine()!);

        Console.Write("Category Id: ");
        int categoryId = int.Parse(Console.ReadLine()!);

        var relation = new BookCategory
        {
            BookId = bookId,
            CategoryId = categoryId
        };

        _context.BookCategories.Add(relation);

        _context.SaveChanges();

        Console.WriteLine("Category added to book.");
    }
}