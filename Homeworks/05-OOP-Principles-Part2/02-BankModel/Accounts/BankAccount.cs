using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankModel
{
    public abstract class BankAccount : IInterestable
    {
        protected Customer Owner;
        protected decimal Balance;
        protected DateTime StartDate;
        readonly public static decimal mouthInterestRateDeposit = 0.015m / 12m;
        readonly public static decimal mouthInterestRateLoad = 0.010m / 12m;
        readonly public static decimal mouthInterestRateMortgage = 0.012m / 12m;

        public BankAccount(Customer owner, decimal balance, DateTime startDate)
        {
            this.Owner = owner;
            this.Balance = balance;
            this.StartDate = startDate;
        }

        public virtual decimal GetBalance
        {
            get { return Balance; }
        }

        public virtual void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public abstract void Withdraw(decimal amount);
        public abstract decimal CalculateInterest(decimal interestRate);

        public abstract string TellRate();
        public abstract string TellBalance();
    }
}
