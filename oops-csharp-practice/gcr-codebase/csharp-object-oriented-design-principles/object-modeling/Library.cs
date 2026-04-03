using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.objectModeling
{
    internal class Library
    {
       
        public class Book
        {
            public string title;
            public string author;

            public Book(string title, string author)
            {
                this.title = title;
                this.author = author;
            }

            public void DisplayBook()
            {
                Console.WriteLine("Book Title : " + title);
                Console.WriteLine("Author     : " + author);
            }
        }

        public string libraryName;
        public List<Book> books;

        public Library(string libraryName)
        {
            this.libraryName = libraryName;
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void DisplayLibrary()
        {
            Console.WriteLine("\nLibrary Name: " + libraryName);
            Console.WriteLine("Books in Library:");

            for (int i = 0; i < books.Count; i++)
            {
                books[i].DisplayBook();
                Console.WriteLine();
            }
        }

        public static void Main(string[] args)
        {
            Book book1 = new Book("C# Basics", "John");
            Book book2 = new Book("OOP Concepts", "Alice");
            Book book3 = new Book("Data Structures", "Robert");

            Library lib1 = new Library("Central Library");
            Library lib2 = new Library("College Library");

            lib1.AddBook(book1);
            lib1.AddBook(book2);

            lib2.AddBook(book2);
            lib2.AddBook(book3);

            lib1.DisplayLibrary();
            lib2.DisplayLibrary();
        }
    }
}
