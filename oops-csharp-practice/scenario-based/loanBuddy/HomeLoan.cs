using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.scenarioBased.loanBuddy
{
        internal class HomeLoan : LoanApplication
        {
            internal HomeLoan(Applicant applicant, int term)
                : base(applicant, term, 7.5) { }

            public override bool ApproveLoan()
            {
                if (applicant.GetCreditScore() >= 700 && applicant.GetIncome() >= 30000)
                {
                    SetLoanStatus(true);
                    return true;
                }
                return false;
            }
        }

    }

