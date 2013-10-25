using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankModel
{
    public abstract class Customer : IComparable<Customer>
    {
        private string firstname;
        private string lastname;

        public string FirstName 
        {
            get
            {
                return firstname;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value) || String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The first name should be filled correctly");
                }
                firstname = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastname;
            }
            private set
            {
                lastname = value;
            }
        }

        public Customer(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Customer(string firstName)
        {
            this.FirstName = firstName;
        }

        public abstract string TellName();

        public int CompareTo(Customer other)
        {
            int resultOfCompare = FirstName.CompareTo(other.FirstName);
            try
            {
                if (resultOfCompare == 0)
                {
                    resultOfCompare = LastName.CompareTo(other.LastName);
                }
            }
            catch (NullReferenceException)
            {

            }
            return resultOfCompare;
        }
    }
}
