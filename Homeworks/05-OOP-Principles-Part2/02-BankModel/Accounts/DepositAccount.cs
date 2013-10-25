using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankModel
{
    public class DepositAccount : BankAccount
    {
        public DepositAccount(Customer owner, decimal balance, DateTime startDate)
            : base(owner, balance, startDate)
        {
        }

        public override void Withdraw(decimal amount)
        {
            if (Balance > amount)
            {
                Balance -= amount;
            }
            else
            {
                throw new ArgumentException("The balance is lower than the required amount");
            }
        }

        public override decimal CalculateInterest(decimal interestRate)
        {
            int months = ((DateTime.Now.Year - StartDate.Year) * 12) + (DateTime.Now.Month - StartDate.Month);
            if (Balance < 1000m)
            {
                return 0.0m;
            }
            else
            {
                decimal rate = Balance * interestRate * months;
                return rate;
            }
            //Balance += rate;
        }

        public override string TellRate()
        {
            return string.Format("Customer: {0} {1}, Current interest {2:C2}", Owner.FirstName, Owner.LastName, CalculateInterest(mouthInterestRateDeposit));
        }

        public override string TellBalance()
        {
            return string.Format("Customer: {0} {1}, Current balance {2:C2}", Owner.FirstName, Owner.LastName, Balance + CalculateInterest(mouthInterestRateDeposit));
        }
    }
}
