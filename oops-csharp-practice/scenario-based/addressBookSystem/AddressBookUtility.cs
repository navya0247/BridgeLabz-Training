using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.scenarioBased.addressBookSystem
{
    internal class AddressBookUtility:IAddressBook
    {
        private Contact[] contacts;
        private int count = 0;

        // ask size from user
        public AddressBookUtility()
        {
            Console.Write("Enter number of contacts you want to store: ");
            int size = int.Parse(Console.ReadLine());
            contacts = new Contact[size];
        }

        // UC2 
        public void AddContact()
        {
            if (count == contacts.Length)
            {
                Console.WriteLine("Address Book is full.");
                return;
            }

            Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Address: ");
            string address = Console.ReadLine();
            Console.Write("City: ");
            string city = Console.ReadLine();
            Console.Write("State: ");
            string state = Console.ReadLine();
            Console.Write("Zip: ");
            string zip = Console.ReadLine();
            Console.Write("Phone: ");
            string phone = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();

            contacts[count++] = new Contact(firstName, lastName, address, city, state, zip, phone, email);
            Console.WriteLine("Contact added.");
        }

        // UC3: Edit existing contact
        public void EditContact()
        {
            Console.Write("Enter Full Name to Edit: ");
            string name = Console.ReadLine();

            for (int i = 0; i < count; i++)
            {
                if (contacts[i].GetFullName().Equals(name))
                {
                    Console.Write("Enter new City: ");
                    contacts[i].City = Console.ReadLine();

                    Console.Write("Enter new State: ");
                    contacts[i].State = Console.ReadLine();

                    Console.WriteLine("\nContact updated successfully.");
                    Console.WriteLine("Updated Contact Details:");
                    Console.WriteLine(contacts[i]);  

                    return;
                }
            }

            Console.WriteLine("Contact not found.");
        }

        // UC4: Delete existing contact
        public void DeleteContact()
        {
            Console.Write("Enter Full Name to Delete: ");
            string name = Console.ReadLine();

            for (int i = 0; i < count; i++)
            {
                if (contacts[i].GetFullName().Equals(name))
                {
                    // Shift elements to left
                    for (int j = i; j < count - 1; j++)
                    {
                        contacts[j] = contacts[j + 1];
                    }

                    contacts[count - 1] = null; 
                    count--;

                    Console.WriteLine("Contact deleted successfully.");
                    return;
                }
            }

            Console.WriteLine("Contact not found.");
        }



    }
}
