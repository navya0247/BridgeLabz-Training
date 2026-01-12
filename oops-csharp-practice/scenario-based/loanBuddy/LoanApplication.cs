using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.oops.scenarioBased.loanBuddy
{  
internal abstract class LoanApplication : IApprovable
    {
        protected Applicant applicant;
        protected int term;             // months
        protected double interestRate;  // annual
        protected bool loanApproved;

        internal LoanApplication(Applicant applicant, int term, double interestRate)
        {
            this.applicant = applicant;
            this.term = term;
            this.interestRate = interestRate;
        }

        // EMI Formula
        public virtual double CalculateEMI()
        {
            double P = applicant.GetLoanAmount();
            double R = interestRate / (12 * 100);
            int N = term;

            return (P * R * Math.Pow(1 + R, N)) / (Math.Pow(1 + R, N) - 1);
        }

        protected internal void SetLoanStatus(bool status)
        {
            loanApproved = status;        }

        public abstract bool ApproveLoan();
    }

}


