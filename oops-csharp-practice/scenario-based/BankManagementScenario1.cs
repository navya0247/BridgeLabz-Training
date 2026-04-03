using System;
using System.Collections.Generic;
using System.Text;

// bank project demo
namespace BridgeLabzTraining.oops.scenarioBased
{
    internal class BankManagementScenario1
    {
        public static void Main(string[] args)
        {
            AccountHandler handler = new AccountHandler();   // object to manage accounts
            UserAccount[] accountRecords = new UserAccount[1000]; // stores accounts
            int currentIndex = 0;   // account number will increase

            while (true)
            {
                Console.WriteLine("\nEnter role: admin | customer | exit");
                string inputRole = Console.ReadLine(); // taking role input

                if (inputRole == "admin")
                {
                    Console.WriteLine("1. Open New Account");
                    Console.WriteLine("2. Add Funds (Admin)");
                    int adminSelection = int.Parse(Console.ReadLine()); // admin choice

                    switch (adminSelection)
                    {
                        case 1:
                            Console.Write("Customer Name: ");
                            string custName = Console.ReadLine();

                            Console.Write("Initial Deposit: ");
                            int initAmount = int.Parse(Console.ReadLine());

                            // creating account and storing it
                            accountRecords[currentIndex] = handler.OpenNewAccount(currentIndex, custName, initAmount);

                            Console.WriteLine("Account successfully generated!");
                            Console.WriteLine("Generated Account ID: " + currentIndex);
                            Console.WriteLine("Starting Balance: " + initAmount);

                            currentIndex++;  // next account ID
                            break;

                        case 2:
                            Console.Write("Enter Account ID: ");
                            int accountId = int.Parse(Console.ReadLine());

                            Console.Write("Enter Amount to Add: ");
                            int addFunds = int.Parse(Console.ReadLine());

                            // admin adding money
                            handler.AdminAddFunds(accountRecords[accountId], addFunds);
                            break;
                    }
                }
                else if (inputRole == "customer")
                {
                    Console.WriteLine("1. View Balance");
                    Console.WriteLine("2. Add Money");
                    Console.WriteLine("3. Withdraw Money");
                    int customerSelection = int.Parse(Console.ReadLine());

                    Console.Write("Enter Account ID: ");
                    int enteredId = int.Parse(Console.ReadLine());

                    switch (customerSelection)
                    {
                        case 1:
                            // show balance
                            Console.WriteLine("Current Balance: " + accountRecords[enteredId].GetBalance());
                            break;

                        case 2:
                            Console.Write("Amount to Add: ");
                            int addAmount = int.Parse(Console.ReadLine());
                            accountRecords[enteredId].AddAmount(addAmount); // deposit
                            break;

                        case 3:
                            Console.Write("Amount to Withdraw: ");
                            int withAmount = int.Parse(Console.ReadLine());
                            accountRecords[enteredId].WithdrawAmount(withAmount); // withdraw
                            break;
                    }
                }
                else
                {
                    // exit the loop
                    break;
                }
            }
        }
    }

    // class to hold money
    public class Wallet
    {
        private double storedBalance; // balance of user

        protected void SetBalance(double money)
        {
            storedBalance = money; // changing balance
        }

        public double GetBalance()
        {
            return storedBalance; // returning balance
        }
    }

    // user account
    public class UserAccount : Wallet
    {
        public string HolderName; // account holder name
        private int UniqueAccountId; // account id

        public UserAccount(int id, string name, int initialBalance)
        {
            // assigning values
            UniqueAccountId = id;
            HolderName = name;
            SetBalance(initialBalance);
        }

        public void AddAmount(int money)
        {
            // increase balance
            SetBalance(GetBalance() + money);
            Console.WriteLine("Amount Added Successfully!");
        }

        public void WithdrawAmount(int money)
        {
            // checking money is enough
            if (money > GetBalance())
            {
                Console.WriteLine("Error: Not enough balance!");
                return;
            }

            // reduce balance
            SetBalance(GetBalance() - money);
            Console.WriteLine("Withdrawal Completed!");
        }
    }

    // admin doing account operations
    public class AccountHandler
    {
        public UserAccount OpenNewAccount(int id, string name, int amount)
        {
            return new UserAccount(id, name, amount); // creating new account
        }

        public void AdminAddFunds(UserAccount user, int amount)
        {
            user.AddAmount(amount); // admin adds money
            Console.WriteLine("New Balance: " + user.GetBalance());
        }
    }
}
