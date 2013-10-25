using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankModel
{
    public class IndividualCustomer : Customer
    {
        private string id;

        public string IDNumber
        {
            get
            {
                return id;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value) || String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The ID number should be filled correctly");
                }
                id = value;
            }
        }

        public IndividualCustomer(string firstName, string lastName, string idNumber)
            : base(firstName, lastName)
        {
            this.IDNumber = idNumber;
        }

        public override string TellName()
        {
            return string.Format("Customer: {0} {1}, ID Number {2}", FirstName, LastName, IDNumber);
        }
    }
}
