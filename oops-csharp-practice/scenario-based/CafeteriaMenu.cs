using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.scenarioBased
{
    internal class CafeteriaMenu
    {
        private string[] menuItems = new string[10]; // 10 items

        // owner enters food items 
        public void AddFixedItems()
        {
            Console.WriteLine("\n Owner: Enter 10 Food Items ");
            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.Write("Enter item " + (i + 1) + ": ");
                menuItems[i] = Console.ReadLine();
            }
            Console.WriteLine("All 10 items added successfully!");
        }

        // show the menu
        public void DisplayMenu()
        {
            Console.WriteLine("\n Cafeteria Menu ");
            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.WriteLine(i + ". " + menuItems[i]);
            }
        }

        // return selected item
        public string GetItemByIndex(int index)
        {
            if (index >= 0 && index < menuItems.Length)
                return menuItems[index];
            else
                return "Invalid item number!";
        }
    }


    internal class Program
    {
        public static void Main(string[] args)
        {
            CafeteriaMenu cafe = new CafeteriaMenu();
            bool itemsAdded = false;

            while (true)
            {
                Console.WriteLine("\n Login Menu---> ");
                Console.WriteLine("1. Owner");
                Console.WriteLine("2. Customer");
                Console.WriteLine("3. Exit System");
                Console.Write("Enter your role: ");
                int loginChoice = int.Parse(Console.ReadLine());

                switch (loginChoice)
                {
                    // OWNER panel
                    case 1:
                        bool ownerRunning = true;
                        while (ownerRunning)
                        {
                            Console.WriteLine("\n OWNER PANEL---> ");
                            Console.WriteLine("1. Add Food Items");
                            Console.WriteLine("2. View Menu");
                            Console.WriteLine("3. Back to Login Menu");
                            Console.Write("Enter choice: ");
                            int ownerChoice = int.Parse(Console.ReadLine());

                            switch (ownerChoice)
                            {
                                case 1:
                                    cafe.AddFixedItems();
                                    itemsAdded = true;
                                    break;

                                case 2:
                                    if (itemsAdded)
                                        cafe.DisplayMenu();
                                    else
                                        Console.WriteLine("\nPlease add items first!");
                                    break;

                                case 3:
                                    ownerRunning = false;
                                    break;

                                default:
                                    Console.WriteLine("Invalid choice!");
                                    break;
                            }
                        }
                        break;

                    // CUSTOMER panel
                    case 2:
                        if (!itemsAdded)
                        {
                            Console.WriteLine("\nItems not added yet! Ask owner to add first.");
                            break;
                        }

                        bool userRunning = true;
                        while (userRunning)
                        {
                            Console.WriteLine("\n CUSTOMER PANEL---> ");
                            Console.WriteLine("1. Order Items by Index");
                            Console.WriteLine("2. Back to Login Menu");
                            Console.Write("Enter choice: ");
                            int userChoice = int.Parse(Console.ReadLine());

                            switch (userChoice)
                            {
                                case 1:
                                    cafe.DisplayMenu();

                                    Console.Write("\nHow many items you want to order? ");
                                    int totalItems = int.Parse(Console.ReadLine());

                                    Console.WriteLine("\nYour Order List:");
                                    for (int i = 0; i < totalItems; i++)
                                    {
                                        Console.Write("Enter item number " + (i + 1) + ": ");
                                        int idx = int.Parse(Console.ReadLine());
                                        Console.WriteLine("- " + cafe.GetItemByIndex(idx));
                                    }

                                    Console.WriteLine("\nThank you for ordering! Enjoy your meal :)");
                                    break;

                                case 2:
                                    userRunning = false;
                                    break;

                                default:
                                    Console.WriteLine("Invalid choice!");
                                    break;
                            }
                        }
                        break;

                    case 3:
                        Console.WriteLine("System Closed! Have a nice day ");
                        return;

                    default:
                        Console.WriteLine("Invalid role! Try again.");
                        break;
                }
            }
        }
    }
}
