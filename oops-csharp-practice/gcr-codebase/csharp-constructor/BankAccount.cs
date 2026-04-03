using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.constructors
{
    internal class BankAccount
    {
            public long accountNumber;    // public
            protected string accountHolder; // protected
            private double balance;       // private

            public BankAccount(long accNo, string holder, double bal)
            {
                accountNumber = accNo;
                accountHolder = holder;
                balance = bal;
            }

            // public methods to access/modify balance
            public double GetBalance()
            {
                return balance;
            }

            public void Deposit(double amount)
            {
                balance = balance + amount;
            }

            public void Withdraw(double amount)
            {
                balance = balance - amount;
            }
        }

        internal class SavingsAccount : BankAccount
        {
            public SavingsAccount(long accNo, string holder, double bal)
                : base(accNo, holder, bal)
            {
            }

            public static void Main(string[] args)
            {
                SavingsAccount sa = new SavingsAccount(99887766, "Navya", 5000);

                Console.WriteLine("Account Number: " + sa.accountNumber);
                Console.WriteLine("Account Holder : " + sa.accountHolder);
                Console.WriteLine("Balance: " + sa.GetBalance());

                sa.Deposit(1500);
                Console.WriteLine("Balance after Deposit: " + sa.GetBalance());
            }
        }
    }
