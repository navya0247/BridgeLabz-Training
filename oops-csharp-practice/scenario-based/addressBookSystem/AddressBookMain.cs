using System;
using System.Collections.Generic;
using System.Text;


namespace BridgeLabzTraining.oops.scenarioBased.addressBookSystem
{
    internal class AddressBookMain
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("  WELCOME TO ADDRESS BOOK SYSTEM ---> ");
            AddressBookMenu menu = new AddressBookMenu();
            menu.ShowMenu();
        }
    }
}
