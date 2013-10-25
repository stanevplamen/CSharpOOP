using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankModel
{
    public class CompanyCustomer : Customer
    {
        private string number;

        public string TaxNumber
        {
            get
            {
                return number;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value) || String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The Tax number should be filled correctly");
                }
                number = value;
            }
        }

        public CompanyCustomer(string firstName, string taxNumber)
            : base(firstName)
        {
            this.TaxNumber = taxNumber;
        }

        public override string TellName()
        {
            return string.Format("Customer: {0}, Tax Number {1}", FirstName, TaxNumber);
        }
    }
}
