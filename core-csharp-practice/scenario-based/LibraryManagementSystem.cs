using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.scenarioBased
{
    internal class LibraryManagementSystem
    {
        public static void Main(string[] args)
        {

            // taking number of books
            Console.WriteLine("Enter number of books:");
            int size = int.Parse(Console.ReadLine());

            // arrays for book details
            string[] title = new string[size];
            string[] author = new string[size];
            string[] bookStatus = new string[size];

            // taking book information from user
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter title of book" + (i + 1) + ":");
                title[i] = Console.ReadLine();

                Console.WriteLine("Enter author of book" + (i + 1) + ":");
                author[i] = Console.ReadLine();

                Console.WriteLine("Enter status of book (available / checkedOut):");
                bookStatus[i] = Console.ReadLine();

            }


            Console.WriteLine("Enter login type (1 for Librarian / 2 for User):");
            string adminChoice = Console.ReadLine();

            if (adminChoice == "1")   // librarian
            {
                Console.WriteLine("1. Search Book");
                Console.WriteLine("2. Display Book");
                Console.WriteLine("3. Update Book status");
            }
            else if (adminChoice == "2")  // user
            {
                Console.WriteLine("1. Search Book");
                Console.WriteLine("2. Display Book");
            }
            else
            {
                Console.WriteLine("Invalid login type!");
                return;
            }
                Console.WriteLine("Enter your choice");
            string choice = Console.ReadLine();


            switch (adminChoice) // for librarian
            {
                case "1":
                    switch (choice)
                    {
                        case "1":
                            Console.WriteLine(Searching(title, bookStatus));
                            break;

                        case "2":
                            Console.WriteLine(Displaying(title, author));
                            break;

                        case "3":
                            Console.WriteLine(UpdatingBookStatus(title, bookStatus));
                            break;

                        default:
                            Console.WriteLine("Invalid choice");
                            break;

                    }
                    break;

                case "2": //for user
                    switch (choice)
                    {
                        case "1":
                            Console.WriteLine(Searching(title, bookStatus));
                            break;

                        case "2":
                            Console.WriteLine(Displaying(title, author));
                            break;

                    }
                    break;
            }
            }


        //create method for searching book
        public static string Searching(string[] title, string[] bookStatus)
        {
            Console.WriteLine("Enter search word ");
            string word = Console.ReadLine();
           

            for (int i = 0; i < title.Length; i++)
            {
                if (title[i].Equals(word) )
                {
                    return bookStatus[i];

                }
            }
            return "Book not found";


        }
        
        //create method for displaying book
        public static string Displaying(string[] title,string[] author)
        {
            string res = "";
            Console.WriteLine("Book List :");
            for(int i = 0; i < title.Length; i++)
            {
                res+=title[i] +" : "+ author[i]+"\n";
            }
            return res;
        }

        //create method for updating book status
        public static string UpdatingBookStatus(string[] title,string[] bookStatus)
        {
            Console.WriteLine("Enter book status to update:");
            string word = Console.ReadLine();
            for(int i = 0; i < title.Length; i++)
            {
                if (title[i].Equals(word))
                {
                     
                    Console.WriteLine("Enter new status:");
                    bookStatus[i] = Console.ReadLine();
                    return "Book status updated succesfully:";

                }
            }
            return "Book not found";


        }

    }
}
    

