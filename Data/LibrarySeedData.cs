using LibrarySystem.Models;

namespace LibrarySystem.Data;

public static class LibrarySeedData
{
    public static List<Book> Books = new()
    {
    new Book { Id = 1, Title = "Harry Potter and the Sorcerer's Stone", ISBN = "100001", PublishedYear = 1997, AuthorId = 1 },
    new Book { Id = 2, Title = "Harry Potter and the Chamber of Secrets", ISBN = "100002", PublishedYear = 1998, AuthorId = 1 },
    new Book { Id = 3, Title = "Harry Potter and the Prisoner of Azkaban", ISBN = "100003", PublishedYear = 1999, AuthorId = 1 },
    new Book { Id = 4, Title = "Harry Potter and the Goblet of Fire", ISBN = "100004", PublishedYear = 2000, AuthorId = 1 },
    new Book { Id = 5, Title = "Harry Potter and the Order of the Phoenix", ISBN = "100005", PublishedYear = 2003, AuthorId = 1 },
    new Book { Id = 6, Title = "Harry Potter and the Half-Blood Prince", ISBN = "100006", PublishedYear = 2005, AuthorId = 1 },
    new Book { Id = 7, Title = "Harry Potter and the Deathly Hallows", ISBN = "100007", PublishedYear = 2007, AuthorId = 1 },
    new Book { Id = 8, Title = "1984", ISBN = "200001", PublishedYear = 1949, AuthorId = 2 },
    new Book { Id = 9, Title = "Animal Farm", ISBN = "200002", PublishedYear = 1945, AuthorId = 2 },
    new Book { Id = 10, Title = "Brave New World", ISBN = "200003", PublishedYear = 1932, AuthorId = 3 },
    new Book { Id = 11, Title = "Fahrenheit 451", ISBN = "200004", PublishedYear = 1953, AuthorId = 4 },
    new Book { Id = 12, Title = "The Handmaid's Tale", ISBN = "200005", PublishedYear = 1985, AuthorId = 5 },
    new Book { Id = 13, Title = "The Hobbit", ISBN = "300001", PublishedYear = 1937, AuthorId = 6 },
    new Book { Id = 14, Title = "The Lord of the Rings: Fellowship", ISBN = "300002", PublishedYear = 1954, AuthorId = 6 },
    new Book { Id = 15, Title = "The Two Towers", ISBN = "300003", PublishedYear = 1954, AuthorId = 6 },
    new Book { Id = 16, Title = "The Return of the King", ISBN = "300004", PublishedYear = 1955, AuthorId = 6 },
    new Book { Id = 17, Title = "Dune", ISBN = "400001", PublishedYear = 1965, AuthorId = 7 },
    new Book { Id = 18, Title = "Dune Messiah", ISBN = "400002", PublishedYear = 1969, AuthorId = 7 },
    new Book { Id = 19, Title = "Children of Dune", ISBN = "400003", PublishedYear = 1976, AuthorId = 7 },
    new Book { Id = 20, Title = "God Emperor of Dune", ISBN = "400004", PublishedYear = 1981, AuthorId = 7 },
    new Book { Id = 21, Title = "The Da Vinci Code", ISBN = "500001", PublishedYear = 2003, AuthorId = 8 },
    new Book { Id = 22, Title = "Angels & Demons", ISBN = "500002", PublishedYear = 2000, AuthorId = 8 },
    new Book { Id = 23, Title = "Inferno", ISBN = "500003", PublishedYear = 2013, AuthorId = 8 },
    new Book { Id = 24, Title = "Origin", ISBN = "500004", PublishedYear = 2017, AuthorId = 8 },
    new Book { Id = 25, Title = "The Shining", ISBN = "600001", PublishedYear = 1977, AuthorId = 9 },
    new Book { Id = 26, Title = "It", ISBN = "600002", PublishedYear = 1986, AuthorId = 9 },
    new Book { Id = 27, Title = "Misery", ISBN = "600003", PublishedYear = 1987, AuthorId = 9 },
    new Book { Id = 28, Title = "Carrie", ISBN = "600004", PublishedYear = 1974, AuthorId = 9 },
    new Book { Id = 29, Title = "The Alchemist", ISBN = "700001", PublishedYear = 1988, AuthorId = 10 },
    new Book { Id = 30, Title = "Brida", ISBN = "700002", PublishedYear = 1990, AuthorId = 10 },
    new Book { Id = 31, Title = "Veronika Decides to Die", ISBN = "700003", PublishedYear = 1998, AuthorId = 10 },
    new Book { Id = 32, Title = "Eleven Minutes", ISBN = "700004", PublishedYear = 2003, AuthorId = 10 },
    new Book { Id = 33, Title = "Sherlock Holmes: Study in Scarlet", ISBN = "800001", PublishedYear = 1887, AuthorId = 11 },
    new Book { Id = 34, Title = "Sherlock Holmes: Sign of Four", ISBN = "800002", PublishedYear = 1890, AuthorId = 11 },
    new Book { Id = 35, Title = "Sherlock Holmes: Hound of Baskervilles", ISBN = "800003", PublishedYear = 1902, AuthorId = 11 },
    new Book { Id = 36, Title = "Lost World", ISBN = "800004", PublishedYear = 1912, AuthorId = 11 },
    new Book { Id = 37, Title = "The Silent Patient", ISBN = "900001", PublishedYear = 2019, AuthorId = 12 },
    new Book { Id = 38, Title = "The Maidens", ISBN = "900002", PublishedYear = 2021, AuthorId = 12 },
    new Book { Id = 39, Title = "The Fury", ISBN = "900003", PublishedYear = 2024, AuthorId = 12 },
    new Book { Id = 40, Title = "Mystery of the Mind", ISBN = "900004", PublishedYear = 2022, AuthorId = 12 }
    };

    public static List<Category> Categories = new()
    {
        new Category { Id = 1, Name = "Fantasy" },
        new Category { Id = 2, Name = "Dystopian" },
        new Category { Id = 3, Name = "Sci-Fi" },
        new Category { Id = 4, Name = "Mystery" },
        new Category { Id = 5, Name = "Horror" }
    };

    public static List<BookCategory> BookCategories = new()
    {
    new BookCategory { BookId = 1, CategoryId = 1 },
    new BookCategory { BookId = 2, CategoryId = 1 },
    new BookCategory { BookId = 3, CategoryId = 1 },
    new BookCategory { BookId = 4, CategoryId = 1 },
    new BookCategory { BookId = 8, CategoryId = 2 },
    new BookCategory { BookId = 9, CategoryId = 2 },
    new BookCategory { BookId = 10, CategoryId = 2 },
    new BookCategory { BookId = 11, CategoryId = 3 },
    new BookCategory { BookId = 17, CategoryId = 3 },
    new BookCategory { BookId = 18, CategoryId = 3 },
    new BookCategory { BookId = 21, CategoryId = 4 },
    new BookCategory { BookId = 22, CategoryId = 4 },
    new BookCategory { BookId = 37, CategoryId = 4 },
    new BookCategory { BookId = 38, CategoryId = 4 },
    new BookCategory { BookId = 25, CategoryId = 5 },
    new BookCategory { BookId = 26, CategoryId = 5 },
    new BookCategory { BookId = 28, CategoryId = 5 },
    new BookCategory { BookId = 13, CategoryId = 1 },
    new BookCategory { BookId = 14, CategoryId = 1 }
    };
}