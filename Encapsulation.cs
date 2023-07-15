using System;
using System.Collections.Generic;

public class Author
{
    public string Name { get; set; }
    public string Biography { get; set; }

    public Author(string name, string biography)
    {
        Name = name;
        Biography = biography;
    }
}

public class Book
{
    public string Title { get; set; }
    public Author Author { get; set; }
    public int PublicationYear { get; set; }

    public Book(string title, Author author, int publicationYear)
    {
        Title = title;
        Author = author;
        PublicationYear = publicationYear;
    }
}

public class Library
{
    public List<Book> Books { get; set; }

    public Library()
    {
        Books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        Books.Add(book);
        Console.WriteLine($"Added book: {book.Title}");
    }

    public List<Book> SearchByTitle(string title)
    {
        List<Book> foundBooks = new List<Book>();

        foreach (var book in Books)
        {
            if (book.Title.Contains(title, StringComparison.OrdinalIgnoreCase))
            {
                foundBooks.Add(book);
            }
        }

        return foundBooks;
    }

    public List<Book> SearchByAuthor(string authorName)
    {
        List<Book> foundBooks = new List<Book>();

        foreach (var book in Books)
        {
            if (book.Author.Name.Contains(authorName, StringComparison.OrdinalIgnoreCase))
            {
                foundBooks.Add(book);
            }
        }

        return foundBooks;
    }

    public void DisplayAvailableBooks()
    {
        Console.WriteLine("Available Books:");

        foreach (var book in Books)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author.Name}, Publication Year: {book.PublicationYear}");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Creating authors
        Author author1 = new Author("John Smith", "Biography of John Smith");
        Author author2 = new Author("Jane Doe", "Biography of Jane Doe");

        // Creating books
        Book book1 = new Book("Book 1", author1, 2021);
        Book book2 = new Book("Book 2", author2, 2022);

        // Creating a library and adding books
        Library library = new Library();
        library.AddBook(book1);
        library.AddBook(book2);

        // Searching for books by title and author
        List<Book> booksByTitle = library.SearchByTitle("book");
        Console.WriteLine("Books found by title:");
        foreach (var book in booksByTitle)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author.Name}");
        }

        List<Book> booksByAuthor = library.SearchByAuthor("smith");
        Console.WriteLine("Books found by author:");
        foreach (var book in booksByAuthor)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author.Name}");
        }

        // Displaying available books
        library.DisplayAvailableBooks();
    }
}
