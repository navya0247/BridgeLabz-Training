using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.constructors
{
    internal class BookClass
    {
        public string Title;
        public string Author;
        public double Price;

        // Default Constructor
        public BookClass()
        {
            Title = "java";
            Author = "unknown";
            Price = 210;
        }

        // Parameterized Constructor
        public BookClass(string title, string author, double price)
        {
            Title = title;
            Author = author;
            Price = price;
        }
    

        public static void Main(string[] args)
        {
            // Using default constructor
            BookClass book1 = new BookClass();
            Console.WriteLine("Title: " + book1.Title);
            Console.WriteLine("Author: " + book1.Author);
            Console.WriteLine("Price: " + book1.Price);

            // Using parameterized constructor
            BookClass book2 = new BookClass("Python", "Guido", 250.00);
            Console.WriteLine("Title: " + book2.Title);
            Console.WriteLine("Author: " + book2.Author);
            Console.WriteLine("Price: " + book2.Price);
        }
    }
}

