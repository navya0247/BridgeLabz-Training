using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.scenarioBased.addressBookSystem
{
        internal class AddressBookUtility : IAddressBook
        {
            private Contact[] contacts;
            private int count = 0;

            // Constructor
            public AddressBookUtility()
            {
                Console.Write("\nEnter maximum number of contacts for this Address Book: ");
                int size = int.Parse(Console.ReadLine());
                contacts = new Contact[size];

                Console.WriteLine(" Address Book initialized successfully!");
            }

            // UC-6 Storage
            private static AddressBookUtility[] addressBooks = new AddressBookUtility[10];
            private static string[] addressBookNames = new string[10];
            private static int addressBookCount = 0;

            // UC-6 Create Address Book
            public static void CreateAddressBook()
            {
                if (addressBookCount >= addressBooks.Length)
                {
                    Console.WriteLine(" Maximum address book limit reached!");
                    return;
                }

                Console.Write("\nEnter unique Address Book name: ");
                string name = Console.ReadLine();

                for (int i = 0; i < addressBookCount; i++)
                {
                    if (addressBookNames[i].Equals(name, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine(" Address Book already exists!");
                        return;
                    }
                }

                addressBooks[addressBookCount] = new AddressBookUtility();
                addressBookNames[addressBookCount++] = name;

                Console.WriteLine(" Address Book created successfully!");
            }

            // UC-6 Select Address Book
            public static AddressBookUtility SelectAddressBook()
            {
                Console.Write("\nEnter Address Book name to select: ");
                string name = Console.ReadLine();

                for (int i = 0; i < addressBookCount; i++)
                {
                    if (addressBookNames[i].Equals(name, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($" Address Book '{name}' selected!");
                        return addressBooks[i];
                    }
                }

                Console.WriteLine(" Address Book not found!");
                return null;
            }

            // UC-2 + UC-7 Add Contact
            public void AddContact()
            {
                if (count == contacts.Length)
                {
                    Console.WriteLine(" Address Book is full!");
                    return;
                }

                Console.WriteLine("\n--- ADD NEW CONTACT ---");
                Console.Write("First Name : ");
                string firstName = Console.ReadLine();
                Console.Write("Last Name  : ");
                string lastName = Console.ReadLine();

                for (int i = 0; i < count; i++)
                {
                    if (contacts[i].FirstName.Equals(firstName) &&
                        contacts[i].LastName.Equals(lastName))
                    {
                        Console.WriteLine(" Duplicate contact not allowed!");
                        return;
                    }
                }

                Console.Write("Address    : ");
                string address = Console.ReadLine();
                Console.Write("City       : ");
                string city = Console.ReadLine();
                Console.Write("State      : ");
                string state = Console.ReadLine();
                Console.Write("Zip        : ");
                string zip = Console.ReadLine();
                Console.Write("Phone      : ");
                string phone = Console.ReadLine();
                Console.Write("Email      : ");
                string email = Console.ReadLine();

                contacts[count++] = new Contact(firstName, lastName, address, city, state, zip, phone, email);

                Console.WriteLine(" Contact added successfully!");
            }

            // UC-3 Edit Contact
            public void EditContact()
            {
                Console.Write("\nEnter Full Name to edit: ");
                string name = Console.ReadLine();

                for (int i = 0; i < count; i++)
                {
                    if (contacts[i].GetFullName().Equals(name))
                    {
                        Console.Write("Enter new City  : ");
                        contacts[i].City = Console.ReadLine();
                        Console.Write("Enter new State : ");
                        contacts[i].State = Console.ReadLine();

                        Console.WriteLine(" Contact updated successfully!");
                        Console.WriteLine(contacts[i]);
                        return;
                    }
                }

                Console.WriteLine(" Contact not found!");
            }

            // UC-4 Delete Contact
            public void DeleteContact()
            {
                Console.Write("\nEnter Full Name to delete: ");
                string name = Console.ReadLine();

                for (int i = 0; i < count; i++)
                {
                    if (contacts[i].GetFullName().Equals(name))
                    {
                        for (int j = i; j < count - 1; j++)
                            contacts[j] = contacts[j + 1];

                        contacts[count - 1] = null;
                        count--;

                        Console.WriteLine(" Contact deleted successfully!");
                        return;
                    }
                }

                Console.WriteLine(" Contact not found!");
            }

            // UC-5 Add Multiple Contacts
            public void AddMultipleContacts()
            {
                char choice;

                do
                {
                    AddContact();

                    if (count == contacts.Length)
                    {
                        Console.WriteLine(" Address Book full. Cannot add more.");
                        break;
                    }

                    Console.Write("Do you want to add another contact? (y/n): ");
                    choice = Console.ReadLine().ToLower()[0];

                } while (choice == 'y');
            }


        // UC-8: Search contacts by City or State
        public void SearchByCityOrState()
        {
            Console.Write("\nEnter City or State to search: ");
            string input = Console.ReadLine();

            bool found = false;

            Console.WriteLine("\n--- SEARCH RESULTS ---");

            for (int i = 0; i < count; i++)
            {
                if (contacts[i].City.Equals(input, StringComparison.OrdinalIgnoreCase) ||
                    contacts[i].State.Equals(input, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(contacts[i]);
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine(" No contacts found for given City/State.");
            }
        }

        // UC-9: View persons by City or State
        public void ViewPersonsByCityOrState()
        {
            Console.Write("\nEnter City or State to view persons: ");
            string input = Console.ReadLine();

            bool found = false;

            Console.WriteLine("\n--- PERSONS LIST ---");

            for (int i = 0; i < count; i++)
            {
                if (contacts[i].City.Equals(input, StringComparison.OrdinalIgnoreCase) ||
                    contacts[i].State.Equals(input, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(contacts[i]);
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine(" No persons found for given City/State.");
            }
        }

        // UC-10: Count persons by City or State
        public void CountPersonsByCityOrState()
        {
            Console.Write("\nEnter City or State to count persons: ");
            string input = Console.ReadLine();

            int totalCount = 0;

            for (int i = 0; i < count; i++)
            {
                if (contacts[i].City.Equals(input, StringComparison.OrdinalIgnoreCase) ||
                    contacts[i].State.Equals(input, StringComparison.OrdinalIgnoreCase))
                {
                    totalCount++;
                }
            }

            Console.WriteLine($"\n Number of persons in '{input}': {totalCount}");
        }

        // UC-11: Sort contacts by person name 
        public void SortContactsByName()
        {
            if (count <= 1)
            {
                Console.WriteLine("\n Not enough contacts to sort.");
                return;
            }

            // Bubble Sort based on First Name
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = 0; j < count - i - 1; j++)
                {
                    if (string.Compare(
                            contacts[j].FirstName, contacts[j + 1].FirstName, StringComparison.OrdinalIgnoreCase) > 0)
                    {
                        // swap
                        Contact temp = contacts[j];
                        contacts[j] = contacts[j + 1];
                        contacts[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("\n Contacts sorted by Person Name:");
            DisplayAllContacts();
        }

            private void DisplayAllContacts()
        {
            if (count == 0)
            {
                Console.WriteLine(" No contacts available.");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(contacts[i]);
            }
        }

        

    }
}




