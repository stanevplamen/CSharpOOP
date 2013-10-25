using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankModel
{
    public class MortgageAccount : BankAccount
    {
        public MortgageAccount(Customer owner, decimal balance, DateTime startDate)
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
            decimal rate;

            if (Owner is CompanyCustomer)
            {
                if (months <= 12)
                {
                    rate = Balance * interestRate * months / 2;
                    return rate;
                }
                else
                {
                    rate = Balance * interestRate * 12 / 2 + Balance * interestRate * (months - 12);
                    return rate;
                }
                //Balance += rate;
            }
            else
            {
                if (months <= 6)
                {
                    rate = Balance * interestRate * months / 2;
                    return rate;
                }
                else
                {
                    rate = Balance * interestRate * 6 / 2 + Balance * interestRate * (months - 6);
                    return rate;
                }
                //Balance += rate;
            }
        }
        public override string TellRate()
        {
            return string.Format("Customer: {0} {1}, Current interest {2:C2}", Owner.FirstName, Owner.LastName, CalculateInterest(mouthInterestRateMortgage));
        }

        public override string TellBalance()
        {
            return string.Format("Customer: {0} {1}, Current balance {2:C2}", Owner.FirstName, Owner.LastName, Balance + CalculateInterest(mouthInterestRateMortgage));
        }
    }
}
