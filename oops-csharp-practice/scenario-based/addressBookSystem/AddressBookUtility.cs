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

    }
}
