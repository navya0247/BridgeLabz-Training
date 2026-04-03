using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.constructors
{
    internal class LibrarySystem
    {

            public string Title;
            public string Author;
            public double Price;
            public bool Availability;

            // Parameterized constructor
            public LibrarySystem(string title, string author, double price, bool availability)
            {
                Title = title;
                Author = author;
                Price = price;
                Availability = availability;
            }

            public void BorrowBook()
            {
                if (Availability)
                {
                    Availability = false;
                    Console.WriteLine(Title + " borrowed successfully.");
                }
                else
                {
                    Console.WriteLine(Title + " is not available.");
                }
            }

            public static void Main(string[] args)
            {
                LibrarySystem ls = new LibrarySystem("java", "navya", 450, true);

                ls.BorrowBook();
                ls.BorrowBook(); // second time
            }
        }
    }



