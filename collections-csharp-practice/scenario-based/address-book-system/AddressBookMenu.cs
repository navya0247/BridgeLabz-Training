namespace AddressBookSystem
{
        internal class AddressBookMenu
        {
            public void ShowMenu()
            {
                AddressBookUtility currentBook = null;

                while (true)
                {
                    Console.WriteLine("\n=================================");
                    Console.WriteLine(" ADDRESS BOOK MENU ");
                    Console.WriteLine("=================================");
                    Console.WriteLine("1. Create Address Book");
                    Console.WriteLine("2. Select Address Book");
                    Console.WriteLine("3. Add Contact");
                    Console.WriteLine("4. Edit Contact");
                    Console.WriteLine("5. Delete Contact");
                    Console.WriteLine("6. Add Multiple Contacts");
                    Console.WriteLine("7. Search by City/State");
                    Console.WriteLine("8. View persons by City/State");
                    Console.WriteLine("9. Count persons by City/State");
                    Console.WriteLine("10. Sort contacts by Person Name");
                    Console.WriteLine("11. Exit");
                    Console.Write("Enter your choice: ");

                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            AddressBookUtility.CreateAddressBook();
                            break;

                        case "2":
                            currentBook = AddressBookUtility.SelectAddressBook();
                            break;

                        case "3":
                            if (currentBook == null)
                                Console.WriteLine(" Please select an address book first!");
                            else
                                currentBook.AddContact();
                            break;

                        case "4":
                            if (currentBook == null)
                                Console.WriteLine(" Please select an address book first!");
                            else
                                currentBook.EditContact();
                            break;

                        case "5":
                            if (currentBook == null)
                                Console.WriteLine(" Please select an address book first!");
                            else
                                currentBook.DeleteContact();
                            break;

                        case "6":
                            if (currentBook == null)
                                Console.WriteLine(" Please select an address book first!");
                            else
                                currentBook.AddMultipleContacts();
                            break;

                        case "7":
                        if (currentBook == null)
                            Console.WriteLine(" Please select an address book first!");
                        else
                            currentBook.SearchByCityOrState();
                        break;

                        case "8":
                        if (currentBook == null)
                            Console.WriteLine(" Please select an address book first!");
                        else
                            currentBook.ViewPersonsByCityOrState();
                        break;

                        case "9":
                        if (currentBook == null)
                            Console.WriteLine(" Please select an address book first!");
                        else
                            currentBook.CountPersonsByCityOrState();
                        break;

                        case "10":
                        if (currentBook == null)
                            Console.WriteLine(" Please select an address book first!");
                        else
                            currentBook.SortContactsByName();
                        break;

                        case "11":
                           Console.WriteLine(" Exiting Address Book System...");
                            return;

                       default:
                            Console.WriteLine(" Invalid choice! Please try again.");
                            break;
                    }
                }
            }
        }
}
    



               
     