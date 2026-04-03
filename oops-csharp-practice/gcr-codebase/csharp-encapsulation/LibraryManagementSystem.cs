using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.encapsulation
{
   // interface for reservation related work
        interface IReservable
        {
            void ReserveItem(string borrowerName);
            bool CheckAvailability();
        }

        // abstract base class
        abstract class LibraryItem
        {
            // encapsulation using private fields
            private int itemId;
            private string title;
            private string author;

            public int ItemId
            {
                get { return itemId; }
                set { itemId = value; }
            }

            public string Title
            {
                get { return title; }
                set { title = value; }
            }

            public string Author
            {
                get { return author; }
                set { author = value; }
            }

            // abstract method
            public abstract int GetLoanDuration();

            // concrete method
            public void GetItemDetails()
            {
                Console.WriteLine("Item ID   : " + ItemId);
                Console.WriteLine("Title     : " + Title);
                Console.WriteLine("Author    : " + Author);
                Console.WriteLine("Loan Days : " + GetLoanDuration());
            }
        }

        // book class
        class Book : LibraryItem, IReservable
        {
            private string borrowerName;
            private bool isAvailable = true;

            public override int GetLoanDuration()
            {
                return 14;
            }

            public void ReserveItem(string name)
            {
                borrowerName = name;
                isAvailable = false;
            }

            public bool CheckAvailability()
            {
                return isAvailable;
            }
        }

        // magazine class
        class Magazine : LibraryItem, IReservable
        {
            private string borrowerName;
            private bool isAvailable = true;

            public override int GetLoanDuration()
            {
                return 7;
            }

            public void ReserveItem(string name)
            {
                borrowerName = name;
                isAvailable = false;
            }

            public bool CheckAvailability()
            {
                return isAvailable;
            }
        }

        // dvd class
        class DVD : LibraryItem, IReservable
        {
            private string borrowerName;
            private bool isAvailable = true;

            public override int GetLoanDuration()
            {
                return 3;
            }

            public void ReserveItem(string name)
            {
                borrowerName = name;
                isAvailable = false;
            }

            public bool CheckAvailability()
            {
                return isAvailable;
            }
        }

        // main class
        internal class LibraryManagementSystem
        {
            static void Main(string[] args)
            {
                Console.Write("Enter number of library items: ");
                int count = int.Parse(Console.ReadLine());

                // array of LibraryItem reference for polymorphism
                LibraryItem[] items = new LibraryItem[count];

                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("\nEnter item type (1-Book, 2-Magazine, 3-DVD): ");
                    int choice = int.Parse(Console.ReadLine());

                    LibraryItem item;

                    if (choice == 1)
                        item = new Book();
                    else if (choice == 2)
                        item = new Magazine();
                    else
                        item = new DVD();

                    Console.Write("Enter item id: ");
                    item.ItemId = int.Parse(Console.ReadLine());

                    Console.Write("Enter title: ");
                    item.Title = Console.ReadLine();

                    Console.Write("Enter author: ");
                    item.Author = Console.ReadLine();

                    items[i] = item;
                }

                Console.WriteLine("\nLibrary item details");

                for (int i = 0; i < items.Length; i++)
                {
                    items[i].GetItemDetails();

                    if (items[i] is IReservable reserve)
                    {
                        Console.WriteLine("Available : " + reserve.CheckAvailability());

                        Console.Write("Enter borrower name to reserve: ");
                        string name = Console.ReadLine();

                        reserve.ReserveItem(name);
                        Console.WriteLine("Item reserved successfully");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
