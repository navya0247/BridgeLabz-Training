using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.objectModeling
{
    internal class Bank
    {
        public string bankName;

        // Constructor
        public Bank(string bankName)
        {
            this.bankName = bankName;
        }

        // Method to open account for a customer
        public void OpenAccount(Customer customer, double amount)
        {
            customer.balance = amount;
            Console.WriteLine("Account opened for " + customer.name +
                              " in " + bankName);
        }
        public class Customer
        {
            public string name;
            public double balance;

            // Constructor
            public Customer(string name)
            {
                this.name = name;
            }

            // Method to view balance
            public void ViewBalance()
            {
                Console.WriteLine(name + "'s Balance: " + balance);
            }
        }

        // Main method
        public static void Main(string[] args)
        {
            Bank bank = new Bank("Campus Bank");

            Customer c1 = new Customer("Rahul");
            Customer c2 = new Customer("Anita");

            bank.OpenAccount(c1, 5000);
            bank.OpenAccount(c2, 8000);

            c1.ViewBalance();
            c2.ViewBalance();
        }
    }
}
