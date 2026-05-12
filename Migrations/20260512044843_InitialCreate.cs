using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LämnaInEntity.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "character varying(70)", maxLength: 70, nullable: false),
                    ISBN = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    PublishedYear = table.Column<int>(type: "integer", nullable: false),
                    AuthorId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookCategories",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "integer", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookCategories", x => new { x.BookId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_BookCategories_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[,]
                {
                    { 1, "jk@example.com", "J.K. Rowling" },
                    { 2, "orwell@example.com", "George Orwell" },
                    { 3, "austen@example.com", "Jane Austen" },
                    { 4, "twain@example.com", "Mark Twain" },
                    { 5, "hemingway@example.com", "Ernest Hemingway" },
                    { 6, "fitzgerald@example.com", "F. Scott Fitzgerald" },
                    { 7, "christie@example.com", "Agatha Christie" },
                    { 8, "tolkien@example.com", "J.R.R. Tolkien" },
                    { 9, "sking@example.com", "Stephen King" },
                    { 10, "murakami@example.com", "Haruki Murakami" },
                    { 11, "tolstoy@example.com", "Leo Tolstoy" },
                    { 12, "vwoolf@example.com", "Virginia Woolf" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Fantasy" },
                    { 2, "Dystopian" },
                    { 3, "Sci-Fi" },
                    { 4, "Mystery" },
                    { 5, "Horror" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "ISBN", "PublishedYear", "Title" },
                values: new object[,]
                {
                    { 1, 1, "100001", 1997, "Harry Potter and the Sorcerer's Stone" },
                    { 2, 1, "100002", 1998, "Harry Potter and the Chamber of Secrets" },
                    { 3, 1, "100003", 1999, "Harry Potter and the Prisoner of Azkaban" },
                    { 4, 1, "100004", 2000, "Harry Potter and the Goblet of Fire" },
                    { 5, 1, "100005", 2003, "Harry Potter and the Order of the Phoenix" },
                    { 6, 1, "100006", 2005, "Harry Potter and the Half-Blood Prince" },
                    { 7, 1, "100007", 2007, "Harry Potter and the Deathly Hallows" },
                    { 8, 2, "200001", 1949, "1984" },
                    { 9, 2, "200002", 1945, "Animal Farm" },
                    { 10, 3, "200003", 1932, "Brave New World" },
                    { 11, 4, "200004", 1953, "Fahrenheit 451" },
                    { 12, 5, "200005", 1985, "The Handmaid's Tale" },
                    { 13, 6, "300001", 1937, "The Hobbit" },
                    { 14, 6, "300002", 1954, "The Lord of the Rings: Fellowship" },
                    { 15, 6, "300003", 1954, "The Two Towers" },
                    { 16, 6, "300004", 1955, "The Return of the King" },
                    { 17, 7, "400001", 1965, "Dune" },
                    { 18, 7, "400002", 1969, "Dune Messiah" },
                    { 19, 7, "400003", 1976, "Children of Dune" },
                    { 20, 7, "400004", 1981, "God Emperor of Dune" },
                    { 21, 8, "500001", 2003, "The Da Vinci Code" },
                    { 22, 8, "500002", 2000, "Angels & Demons" },
                    { 23, 8, "500003", 2013, "Inferno" },
                    { 24, 8, "500004", 2017, "Origin" },
                    { 25, 9, "600001", 1977, "The Shining" },
                    { 26, 9, "600002", 1986, "It" },
                    { 27, 9, "600003", 1987, "Misery" },
                    { 28, 9, "600004", 1974, "Carrie" },
                    { 29, 10, "700001", 1988, "The Alchemist" },
                    { 30, 10, "700002", 1990, "Brida" },
                    { 31, 10, "700003", 1998, "Veronika Decides to Die" },
                    { 32, 10, "700004", 2003, "Eleven Minutes" },
                    { 33, 11, "800001", 1887, "Sherlock Holmes: Study in Scarlet" },
                    { 34, 11, "800002", 1890, "Sherlock Holmes: Sign of Four" },
                    { 35, 11, "800003", 1902, "Sherlock Holmes: Hound of Baskervilles" },
                    { 36, 11, "800004", 1912, "Lost World" },
                    { 37, 12, "900001", 2019, "The Silent Patient" },
                    { 38, 12, "900002", 2021, "The Maidens" },
                    { 39, 12, "900003", 2024, "The Fury" },
                    { 40, 12, "900004", 2022, "Mystery of the Mind" }
                });

            migrationBuilder.InsertData(
                table: "BookCategories",
                columns: new[] { "BookId", "CategoryId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 1 },
                    { 8, 2 },
                    { 9, 2 },
                    { 10, 2 },
                    { 11, 3 },
                    { 13, 1 },
                    { 14, 1 },
                    { 17, 3 },
                    { 18, 3 },
                    { 21, 4 },
                    { 22, 4 },
                    { 25, 5 },
                    { 26, 5 },
                    { 28, 5 },
                    { 37, 4 },
                    { 38, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Authors_Email",
                table: "Authors",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BookCategories_CategoryId",
                table: "BookCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookCategories");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
