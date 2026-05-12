# 📚 Library System

A simple **Library Management Console Application** built with:

<p align="left">
  <img src="https://img.shields.io/badge/C%23-.NET-blueviolet?style=for-the-badge&logo=csharp">
  <img src="https://img.shields.io/badge/Entity%20Framework-Core-512BD4?style=for-the-badge">
  <img src="https://img.shields.io/badge/PostgreSQL-336791?style=for-the-badge&logo=postgresql&logoColor=white">
</p>

---

## 🚀 Project Overview

This project was created for an **Entity Framework Core** school assignment.

The application demonstrates:

✅ CRUD operations
✅ Entity relationships
✅ Entity Framework Core
✅ PostgreSQL integration
✅ Migrations
✅ Seed data
✅ Include() and ThenInclude()
✅ Database constraints

---

# 🏗️ System Structure

## 📘 Entities

### Author

* Id
* Name
* Email

### Book

* Id
* Title
* ISBN
* PublishedYear
* AuthorId

### Category

* Id
* Name

### BookCategory

Junction table for the many-to-many relationship.

---

# 🔗 Relationships

## One-to-Many

One Author can have many Books.

```text
Author -> Books
```

---

## Many-to-Many

Books can belong to multiple Categories.

```text
Books <-> Categories
```

---

# 🛠️ Technologies Used

| Technology            | Purpose                         |
| --------------------- | ------------------------------- |
| C#                    | Main programming language       |
| .NET                  | Console application framework   |
| Entity Framework Core | ORM                             |
| PostgreSQL            | Database                        |
| Npgsql                | PostgreSQL provider for EF Core |

---

# 📁 Project Structure

```text
LibrarySystem
│
├── Data
│   ├── LibraryContext.cs
|   ├── LibrarySeedData.cs
│
├── Models
│   ├── Author.cs
│   ├── Book.cs
│   ├── Category.cs
│   └── BookCategory.cs
│
├── Services
│   └── LibraryService.cs
│
├── Migrations
│
├── Program.cs
│
└── README.md
```

---

# ⚙️ Installation & Setup

## 1️⃣ Clone Project
## 2️⃣ Install .NET SDK
## 3️⃣ Install PostgreSQL
## 4️⃣ Install Entity Framework CLI
```bash
dotnet tool install --global dotnet-ef
```

---

# 📦 Install NuGet Packages

Run these commands inside the project folder:

```bash
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
```

---

# 🗄️ Database Configuration

Open:

```text
Data/LibraryContext.cs
```

Update your connection string:

```csharp
optionsBuilder.UseNpgsql(
    "Host=localhost;Port=5432;Database=LibraryDb;Username=postgres;Password=YOUR_PASSWORD"
);
```

Replace:

```text
YOUR_PASSWORD
```

with your PostgreSQL password.

---

# 🧱 Create Migration

```bash
dotnet ef migrations add InitialCreate
```

---

# 🛢️ Create Database

```bash
dotnet ef database update
```

This automatically creates:

* Tables
* Relationships
* Constraints
* Seed data

---

# ▶️ Run The Application

```bash
dotnet run
```

---

# 🖥️ Console Menu

```text
===== LIBRARY SYSTEM =====

1. Show Books, initial MigrationCreate has 40 Units
2. Add Book
3. Update Book
4. Delete Book
5. Add Category To Book, Manage Relations
6. Show Authors
0. Exit
```

---

# ✨ Features

## ✅ CRUD Operations

* Add books
* Display books
* Update books
* Delete books

---

## ✅ Entity Relationships

### One-to-Many

Author → Books

### Many-to-Many

Books ↔ Categories

---

## ✅ Include() Usage

Related data is loaded using:

```csharp
.Include(b => b.Author)
.ThenInclude()
```

---

## ✅ Constraints

The project includes:

### Required Fields

```csharp
[Required]
```

### Maximum Length

```csharp
[MaxLength]
```

### Unique Constraint

```csharp
.HasIndex(a => a.Email).IsUnique();
```

---

# 🌱 Seed Data

The database is automatically seeded with:

* Authors x12
* Books   x40
* Categories x5

using:

```csharp
HasData()
```

---

# 🧠 What I Learned

* Entity Framework Core basics
* Database migrations
* Relationships in databases
* CRUD operations
* PostgreSQL integration
* Using Include() for related data

---

# 📸 Example Flow

```text
User
 ↓
Program.cs
 ↓
LibraryService.cs
 ↓
LibraryContext.cs
 ↓
PostgreSQL Database
```

---

# 👨‍💻 Author
Masse with His CoPilot ChatGtp.
Created as a school project using:

* C#
* Entity Framework Core
* PostgreSQL
