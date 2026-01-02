using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.keywordsAndOperator
{
    internal class BankSystem
    {
            //  static
            public static string bankName = "Campus Bank";
            private static int totalAccounts = 0; // counting total accounts

            // readonly 
            public readonly int AccountNumber;

            // normal variable
            public string AccountHolderName;
            private double balance;

            //  this 
            public BankSystem(int AccountNumber, string AccountHolderName, double balance)
            {
                this.AccountNumber = AccountNumber;     // using this to refer to current object
                this.AccountHolderName = AccountHolderName;
                this.balance = balance;

                totalAccounts++;   // shared count increases for every new object
            }

            // showing details
            public void ShowDetails()
            {
                Console.WriteLine("\n Account Information ");
                Console.WriteLine("Bank Name : " + bankName);
                Console.WriteLine("Account No: " + AccountNumber);
                Console.WriteLine("Holder    : " + AccountHolderName);
                Console.WriteLine("Balance   : " + balance);
            }

            // static method to show total accounts
            public static void GetTotalAccounts()
            {
                Console.WriteLine("\nTotal accounts created: " + totalAccounts);
            }
        }


        internal class Program
        {
            public static void Main(string[] args)
            {
                Console.WriteLine(" Welcome to Campus Bank System ");

                Console.Write("How many accounts you want to create? : ");
                int n = int.Parse(Console.ReadLine());  // asking from user

            // array to store accounts
            BankSystem[] accounts = new BankSystem[n];

                // taking user input for accounts
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"\n Enter details for account {i + 1} ");

                    Console.Write("Enter Account Number: ");
                    int accNo = int.Parse(Console.ReadLine());

                    Console.Write("Enter Account Holder Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter Opening Balance: ");
                    double bal = double.Parse(Console.ReadLine());

                    // creating object and storing
                    accounts[i] = new BankSystem(accNo, name, bal);
                }

                Console.WriteLine("\n Checking Details ");

                // using is
                for (int i = 0; i < n; i++)
                {
                    if (accounts[i] is BankSystem)    
                    {
                        accounts[i].ShowDetails();
                    }
                }

            // calling static method
            BankSystem.GetTotalAccounts();

                Console.WriteLine("\nThank you for using the system :)");
            }
        }
    }


