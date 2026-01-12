using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.scenarioBased.loanBuddy
{
        internal class PersonalLoan : LoanApplication
        {
            internal PersonalLoan(Applicant applicant, int term) : base(applicant, term, 12.0) { }

            public override bool ApproveLoan()
            {
                if (applicant.GetCreditScore() >= 600 && applicant.GetIncome() >= 25000)
                {
                    SetLoanStatus(true);
                    return true;
                }
                return false;
            }
        }
    }

