using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_author_library_book
{
     class Author
    {
        public string Authorname { get; }

        public Author(string authorName)
        {
          Authorname = authorName;
        }

        class Book
        {
            public string Title { get; }
            public string ISBN{ get; }
            public Author Author { get; }

            public Book(string title, string ISBN,Author author)
            {
                Title = title;
                ISBN = ISBN;
                Author = author;
            }
            public override string ToString()
            {
                return $"Title:{Title}, ISBN:{ISBN},Author:{Author.Authorname}";

            }

        }
        class Library
        {
            private List<Book> books=new List<Book>();
            public void AddBook(Book book)
            {
                books.Add( book );
                Console.WriteLine($"Book added the library:{book}");
            }
            public void RemoveBook(string isbn)
            {
                Book bookToRemove = null; 

                foreach (var book in books)
                {
                    if (book.ISBN==isbn)
                    {
                        bookToRemove = book;
                        break;
                    }

                }
                if(bookToRemove!= null )
                {
                    books.Remove(bookToRemove);
                    Console.WriteLine($"book removed from the library:{bookToRemove}");
                }
                else
                {
                    Console.WriteLine($"book with ISBN(isbn) is not found in the library");
                }

            }
            public void DisplayBook()
            {
                Console.WriteLine("books in the library");
                foreach (var book in books)
                {
                    Console.WriteLine("book");
                }
                Console.WriteLine();
            }
            


        }

        static void Main(string[] args)
        {

            // Create authors
            Author author1 = new Author("John Doe");
            Author author2 = new Author("Jane Smith");

            // Create books
            Book book1 = new Book("Introduction to C#", "123456", author1);
            Book book2 = new Book("Introduction to C#", "789012", author2);
            Book book3 = new Book("Advanced C#", "345678", author1);

            // Create library
            Library library = new Library();

            // Add books to the library
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);

            // Display books in the library
            library.DisplayBook();

            // Remove a book from the library
            library.RemoveBook("789012");

            // Display updated books in the library
            library.DisplayBook();
        }
    }

}
    