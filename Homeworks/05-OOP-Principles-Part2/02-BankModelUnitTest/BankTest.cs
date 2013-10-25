using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankModel;
using System.Collections.Generic;

namespace BankModelUnitTest
{
    [TestClass]
    public class BankTest
    {
        [TestMethod]
        public void TestBankModel1()
        {
            CompanyCustomer PeshoOOD = new CompanyCustomer("Pesho OOD", "BG2134564444");
            IndividualCustomer PeshoPerson = new IndividualCustomer("Petar", "Petrov", "8504042345");
            CompanyCustomer EkyOOD = new CompanyCustomer("EKY OOD", "BG2135785678");

            List<Customer> customerArch = new List<Customer>() { PeshoOOD, PeshoPerson, EkyOOD };
            customerArch.Sort();

            List<string> resultList = new List<string>() { 
                                                        "Customer: EKY OOD, Tax Number BG2135785678",
                                                        "Customer: Pesho OOD, Tax Number BG2134564444",
                                                        "Customer: Petar Petrov, ID Number 8504042345",
                                                        };

            int counter = 0;
            foreach (var customer in customerArch)
            {
                Assert.AreEqual(resultList[counter], customer.TellName());
                counter++;
            }
        }

        [TestMethod]
        public void TestBankModel2()
        {
            CompanyCustomer PeshoOOD = new CompanyCustomer("Pesho OOD", "BG2134564444");
            IndividualCustomer PeshoPerson = new IndividualCustomer("Petar", "Petrov", "8504042345");
            CompanyCustomer EkyOOD = new CompanyCustomer("EKY OOD", "BG2135785678");

            DepositAccount myDeposit = new DepositAccount(PeshoOOD, 4670.50m, new DateTime(2010, 12, 3));
            LoanAccount myLoan = new LoanAccount(PeshoPerson, 1000m, new DateTime(2007, 6, 3));
            MortgageAccount myMortgage = new MortgageAccount(EkyOOD, 45000m, new DateTime(2012, 7, 6));

            List<BankAccount> accountsArch = new List<BankAccount>() { myDeposit, myLoan, myMortgage };

            List<string> resultList = new List<string>() { 
                                                        "DepositAccount",
                                                        "LoanAccount",
                                                        "MortgageAccount",
                                                        };
            int counter = 0;
            foreach (var acc in accountsArch)
            {
                Assert.AreEqual(resultList[counter], acc.GetType().Name);
                counter++;
            }
        }

        [TestMethod]
        public void TestBankModel3()
        {
            CompanyCustomer PeshoOOD = new CompanyCustomer("Pesho OOD", "BG2134564444");
            IndividualCustomer PeshoPerson = new IndividualCustomer("Petar", "Petrov", "8504042345");
            CompanyCustomer EkyOOD = new CompanyCustomer("EKY OOD", "BG2135785678");

            DepositAccount myDeposit = new DepositAccount(PeshoOOD, 4670.50m, new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day));
            LoanAccount myLoan = new LoanAccount(PeshoPerson, 1000m, new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day));
            MortgageAccount myMortgage = new MortgageAccount(EkyOOD, 45000m, new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day));

            List<BankAccount> accountsArch = new List<BankAccount>() { myDeposit, myLoan, myMortgage };

            List<string> resultList = new List<string>() { 
                                                        "Customer: Pesho OOD , Current balance 4 670,50 лв.",
                                                        "Customer: Petar Petrov, Current balance 1 000,00 лв.",
                                                        "Customer: EKY OOD , Current balance 45 000,00 лв.",
                                                        };
            int counter = 0;
            foreach (var acc in accountsArch)
            {
                Assert.AreEqual(resultList[counter], acc.TellBalance());
                counter++;
            }
        }

        [TestMethod]
        public void TestBankModel4()
        {
            CompanyCustomer PeshoOOD = new CompanyCustomer("Pesho OOD", "BG2134564444");
            IndividualCustomer PeshoPerson = new IndividualCustomer("Petar", "Petrov", "8504042345");
            CompanyCustomer EkyOOD = new CompanyCustomer("EKY OOD", "BG2135785678");

            DepositAccount myDeposit = new DepositAccount(PeshoOOD, 4670.50m, DateTime.Now.AddMonths(-6));
            LoanAccount myLoan = new LoanAccount(PeshoPerson, 1000m, DateTime.Now.AddMonths(-6));
            MortgageAccount myMortgage = new MortgageAccount(EkyOOD, 45000m, DateTime.Now.AddMonths(-6));

            List<BankAccount> accountsArch = new List<BankAccount>() { myDeposit, myLoan, myMortgage };

            List<string> resultList = new List<string>() { 
                                                        "Customer: Pesho OOD , Current balance 4 705,53 лв.",
                                                        "Customer: Petar Petrov, Current balance 1 003,33 лв.",
                                                        "Customer: EKY OOD , Current balance 45 135,00 лв.",
                                                        };
            int counter = 0;
            foreach (var acc in accountsArch)
            {
                Assert.AreEqual(resultList[counter], acc.TellBalance());
                counter++;
            }
        }
    }
}
