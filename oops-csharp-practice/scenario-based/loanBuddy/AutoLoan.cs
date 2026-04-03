using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.scenarioBased.loanBuddy
{
        internal class AutoLoan : LoanApplication
        {
            internal AutoLoan(Applicant applicant, int term) : base(applicant, term, 9.0) { }

            public override bool ApproveLoan()
            {
                if (applicant.GetCreditScore() >= 650 && applicant.GetIncome() >= 20000)
                {
                    SetLoanStatus(true);
                    return true;
                }
                return false;
            }
        }
    }

