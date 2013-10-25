using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankModel
{
    public class LoanAccount : BankAccount
    {
        public LoanAccount(Customer owner, decimal balance, DateTime startDate)
            : base(owner, balance, startDate)
        {
        }

        public override void Withdraw(decimal amount)
        {
            /// Msg: This type of account can not perforn the requested operation
            // Balance -= 0.00m;
        }

        public override decimal CalculateInterest(decimal interestRate)
        {
            int months = ((DateTime.Now.Year - StartDate.Year) * 12) + (DateTime.Now.Month - StartDate.Month);

            if (Owner is IndividualCustomer && months > 2)
            {
                months = months - 2;
                decimal rate = Balance * interestRate * months;
                return rate;
            }
            if (Owner is CompanyCustomer && months > 3)
            {
                months = months - 3;
                decimal rate = Balance * interestRate * months;
                return rate;

            }
            else
            {
                return 0.00m;
            }
            //Balance += rate;
        }

        public override string TellRate()
        {
            return string.Format("Customer: {0} {1}, Current interest {2:C2}", Owner.FirstName, Owner.LastName, CalculateInterest(mouthInterestRateLoad));
        }
        public override string TellBalance()
        {
            return string.Format("Customer: {0} {1}, Current balance {2:C2}", Owner.FirstName, Owner.LastName, Balance + CalculateInterest(mouthInterestRateLoad));
        }
    }
}
