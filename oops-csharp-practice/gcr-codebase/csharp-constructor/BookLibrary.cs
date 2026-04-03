using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.constructors
{
    internal class BookLibrary
    {
            public string ISBN;       // public
            protected string title;   // protected
            private string author;    // private

            public BookLibrary(string isbn, string bookTitle, string bookAuthor)
            {
                ISBN = isbn;
                title = bookTitle;
                author = bookAuthor;
            }

            // public methods to set/get private author
            public void SetAuthor(string newAuthor)
            {
                author = newAuthor;
            }

            public string GetAuthor()
            {
                return author;
            }
        }

        internal class EBook : BookLibrary
    {
            public EBook(string isbn, string bookTitle, string bookAuthor)
                : base(isbn, bookTitle, bookAuthor)
            {
            }

            public static void Main(string[] args)
            {
                EBook eb = new EBook("ISBN123", "C# Mastery", "John");

                Console.WriteLine("ISBN: " + eb.ISBN);
                Console.WriteLine("Title : " + eb.title);
                Console.WriteLine("Author: " + eb.GetAuthor());

                eb.SetAuthor("Rohan");
                Console.WriteLine("Updated Author: " + eb.GetAuthor());
            }
        }
    }

