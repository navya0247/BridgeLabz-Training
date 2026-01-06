using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.encapsulation
{
      // interface for loan related operations
        interface ILoanable
        {
            void ApplyForLoan();
            double CalculateLoanEligibility();
        }

        // abstract base class
        abstract class BankAccount
        {
            // encapsulation using private fields
            private int accountNumber;
            private string holderName;
            private double balance;

            // getter and setter
            public int AccountNumber
            {
                get { return accountNumber; }
                set { accountNumber = value; }
            }

            public string HolderName
            {
                get { return holderName; }
                set { holderName = value; }
            }

            public double Balance
            {
                get { return balance; }
                protected set { balance = value; }
            }

            // deposit method
            public void Deposit(double amount)
            {
                if (amount > 0)
                {
                    Balance += amount;
                }
            }

            // withdraw method
            public void Withdraw(double amount)
            {
                if (amount > 0 && amount <= Balance)
                {
                    Balance -= amount;
                }
                else
                {
                    Console.WriteLine("Insufficient balance");
                }
            }

            // abstract method
            public abstract double CalculateInterest();

            // common display method
            public void DisplayAccount()
            {
                Console.WriteLine("Account Number : " + AccountNumber);
                Console.WriteLine("Holder Name    : " + HolderName);
                Console.WriteLine("Balance        : " + Balance);
            }
        }

        // savings account class
        class SavingsAccount : BankAccount, ILoanable
        {
            public override double CalculateInterest()
            {
                return Balance * 0.04; // 4% interest
            }

            public void ApplyForLoan()
            {
                Console.WriteLine("Loan applied from Savings Account");
            }

            public double CalculateLoanEligibility()
            {
                return Balance * 2;
            }
        }

        // current account class
        class CurrentAccount : BankAccount, ILoanable
        {
            public override double CalculateInterest()
            {
                return Balance * 0.02; 
            }

            public void ApplyForLoan()
            {
                Console.WriteLine("Loan applied from Current Account");
            }

            public double CalculateLoanEligibility()
            {
                return Balance * 3;
            }
        }

        // main class
        internal class BankingSystem
        {
            public static void Main(string[] args)
            {
                Console.Write("Enter number of accounts: ");
                int count = int.Parse(Console.ReadLine());

                // array of BankAccount reference for polymorphism
                BankAccount[] accounts = new BankAccount[count];

                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("\nEnter account type (1-Savings, 2-Current): ");
                    int choice = int.Parse(Console.ReadLine());

                    BankAccount acc;

                    if (choice == 1)
                        acc = new SavingsAccount();
                    else
                        acc = new CurrentAccount();

                    Console.Write("Enter account number: ");
                    acc.AccountNumber = int.Parse(Console.ReadLine());

                    Console.Write("Enter holder name: ");
                    acc.HolderName = Console.ReadLine();

                    Console.Write("Enter initial balance: ");
                    acc.Deposit(double.Parse(Console.ReadLine()));

                    accounts[i] = acc;
                }

                // polymorphism in action
                Console.WriteLine("\nAccount details and interest");

                for (int i = 0; i < accounts.Length; i++)
                {
                    accounts[i].DisplayAccount();

                    double interest = accounts[i].CalculateInterest();
                    Console.WriteLine("Calculated Interest : " + interest);

                    if (accounts[i] is ILoanable loan)
                    {
                        loan.ApplyForLoan();
                        Console.WriteLine("Loan Eligibility : " + loan.CalculateLoanEligibility());
                    }

                    Console.WriteLine();
                }
            }
        }
    }
