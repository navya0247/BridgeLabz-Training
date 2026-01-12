using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.scenarioBased.loanBuddy
{
        internal class Applicant
        {
            private string name;
            private int creditScore;
            private double income;
            private double loanAmount;

            internal Applicant(string name, int creditScore, double income, double loanAmount)
            {
                this.name = name;
                this.creditScore = creditScore;
                this.income = income;
                this.loanAmount = loanAmount;
            }

            internal int GetCreditScore()
            {
                return creditScore;
            }

            internal double GetIncome()
            {
                return income;
            }

            internal double GetLoanAmount()
            {
                return loanAmount;
            }

            internal string GetName()
            {
                return name;
            }
        }

    }

