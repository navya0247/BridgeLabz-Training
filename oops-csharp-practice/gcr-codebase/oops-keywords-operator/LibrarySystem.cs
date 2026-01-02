using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.keywordsAndOperator
{
    internal class LibrarySystem
    {
            // static 
            public static string LibraryName = "City Central Library";

            // static method to print library name
            public static void DisplayLibraryName()
            {
                Console.WriteLine("\nWelcome to " + LibraryName);
            }

            // readonly 
            public readonly string ISBN;

            // normal properties
            public string Title;
            public string Author;

            // using 'this' 
            public LibrarySystem(string ISBN, string Title, string Author)
            {
                this.ISBN = ISBN;       
                this.Title = Title;
                this.Author = Author;
            }

            // method to show book details
            public void ShowBookDetails()
            {
                Console.WriteLine("\n Book Information ");
                Console.WriteLine("Library : " + LibraryName);
                Console.WriteLine("Title   : " + Title);
                Console.WriteLine("Author  : " + Author);
                Console.WriteLine("ISBN    : " + ISBN);
            }
        }

        internal class Program
        {
            public static void Main(string[] args)
            {
            // showing library name using static method
            LibrarySystem.DisplayLibraryName();

                Console.Write("\nHow many books do you want to enter? : ");
                int count = int.Parse(Console.ReadLine());

            // array of Book objects
            LibrarySystem[] books = new LibrarySystem[count];

                // taking input from user
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine($"\nEnter details for book {i + 1}:");

                    Console.Write("Enter ISBN (unique): ");
                    string isbn = Console.ReadLine();

                    Console.Write("Enter Title: ");
                    string title = Console.ReadLine();

                    Console.Write("Enter Author: ");
                    string author = Console.ReadLine();

                    books[i] = new LibrarySystem(isbn, title, author); // creating object
                }

                Console.WriteLine("\n\n Displaying All Books");

                //  using 'is' 
                for (int i = 0; i < count; i++)
                {
                    if (books[i] is LibrarySystem)
                    {
                        books[i].ShowBookDetails();
                    }
                }

                Console.WriteLine("\nThank you for using Library System!");
            }
        }
    }

