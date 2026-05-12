using LibrarySystem.Services;

var service = new LibraryService();

bool running = true;

while (running)
{
    Console.WriteLine();
    Console.WriteLine("===== LIBRARY SYSTEM =====");
    Console.WriteLine("1. Show Books, initial MigrationCreate has 40 Units ");
    Console.WriteLine("2. Add Book");
    Console.WriteLine("3. Update Book");
    Console.WriteLine("4. Delete Book");
    Console.WriteLine("5. Add Category To Book, Manage Relations");
    Console.WriteLine("0. Exit");

    Console.Write("Choice: ");

    string choice = Console.ReadLine()!;

    switch (choice)
    {
        case "1":
            service.ShowBooks();
            break;

        case "2":
            service.AddBook();
            break;

        case "3":
            service.UpdateBook();
            break;

        case "4":
            service.DeleteBook();
            break;

        case "5":
            service.AddCategoryToBook();
            break;
            
        case "0":
            running = false;
            break;

        default:
            Console.WriteLine("Invalid choice.");
            break;
    }
}