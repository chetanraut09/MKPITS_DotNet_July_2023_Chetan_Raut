using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_book_author_assi
{
    class Author
    {
        public string AuthorName { get; set; }

        public Author(string authorName)
        {
            AuthorName = authorName;
        }
    }

    class Book
    {
        public string Title { get; set; }
        public string ISBN { get; set; }
        public Author BookAuthor { get; set; }

        public Book(string title, string isbn, Author author)
        {
            Title = title;
            ISBN = isbn;
            BookAuthor = author;
        }

        public override string ToString()
        {
            return $"{Title} (ISBN: {ISBN}) by {BookAuthor.AuthorName}";
        }
    }

    class Library
    {
        private List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void RemoveBook(string isbn)
        {
            Book bookToRemove = books.Find(b => b.ISBN == isbn);

            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
                Console.WriteLine($"Book removed: {bookToRemove.Title}");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }

        public void DisplayBooks()
        {
            Console.WriteLine("List of Books in the Library:");
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            Author author1 = new Author("John Doe");
            Author author2 = new Author("Jane Smith");

            Book book1 = new Book("Introduction to C#", "123456", author1);
            Book book2 = new Book("Advanced C# Programming", "789012", author2);
            Book book3 = new Book("Introduction to C#", "345678", author1);

            Library library = new Library();

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);

            library.DisplayBooks();

            library.RemoveBook("789012");

            library.DisplayBooks();
        }
    }
}