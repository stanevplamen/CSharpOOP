using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankModel
{
    class MainDemo
    {
        static void Main()
        {
            CompanyCustomer PeshoOOD = new CompanyCustomer("Pesho OOD", "BG2134564444");
            IndividualCustomer PeshoPerson = new IndividualCustomer("Petar", "Petrov", "8504042345");
            CompanyCustomer EkyOOD = new CompanyCustomer("EKY OOD", "BG2135785678");

            List<Customer> customerArch = new List<Customer>() { PeshoOOD, PeshoPerson, EkyOOD };
            customerArch.Sort();
            foreach (var customer in customerArch)
            {
                Console.WriteLine(customer.TellName());
            }
            Console.WriteLine();

            DepositAccount myDeposit = new DepositAccount(PeshoOOD, 4670.50m, new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day));
            LoanAccount myLoan = new LoanAccount(PeshoPerson, 1000m, new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day));
            MortgageAccount myMortgage = new MortgageAccount(EkyOOD, 45000m, new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day));

            List<BankAccount> accountsArch = new List<BankAccount>() { myDeposit, myLoan, myMortgage };
            foreach (var acc in accountsArch)
            {
                Console.WriteLine("=================");
                Console.WriteLine("Type of account: {0}", acc.GetType().Name);
                Console.WriteLine(acc.TellBalance());
                Console.WriteLine(acc.TellRate());
                Console.Write("Add 1000 -> ");
                acc.Deposit(1000m);
                Console.WriteLine(acc.TellBalance());
                Console.WriteLine(acc.TellRate());
                Console.Write("Try substract 1000 -> ");
                acc.Withdraw(1000m);
                Console.WriteLine(acc.TellBalance());
                Console.WriteLine(acc.TellRate());
                Console.WriteLine();
            }
        }
    }
}