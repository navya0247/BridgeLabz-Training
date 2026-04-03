using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.scenarioBased.loanBuddy
{
    internal class LoanBuddyMain{    
        public static void Main(string[] args)
        {
            Console.Write("Enter applicant name: ");
            string name = Console.ReadLine();

            Console.Write("Enter credit score: ");
            int creditScore = int.Parse(Console.ReadLine());

            Console.Write("Enter monthly income: ");
            double income = double.Parse(Console.ReadLine());

            Console.Write("Enter loan amount: ");
            double loanAmount = double.Parse(Console.ReadLine());

            Console.Write("Enter loan term (in months): ");
            int term = int.Parse(Console.ReadLine());

            Console.WriteLine("Select loan type: 1.Personal  2.Home  3.Auto");
            int choice = int.Parse(Console.ReadLine());

            Applicant applicant = new Applicant(name, creditScore, income, loanAmount);
            LoanApplication loan = null;

            if (choice == 1)
                loan = new PersonalLoan(applicant, term);
            else if (choice == 2)
                loan = new HomeLoan(applicant, term);
            else if (choice == 3)
                loan = new AutoLoan(applicant, term);
            else
            {
                Console.WriteLine("Invalid loan type!");
                return;
            }

            if (loan.ApproveLoan())
            {
                Console.WriteLine("\nLoan Approved for " + applicant.GetName());
                Console.WriteLine("Monthly EMI: " + loan.CalculateEMI());
            }
            else
            {
                Console.WriteLine("\nLoan Rejected for " + applicant.GetName());
            }
        }
    }

}



