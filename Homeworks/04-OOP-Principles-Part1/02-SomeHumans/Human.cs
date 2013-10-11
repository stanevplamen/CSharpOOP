using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeHumans
{
    public abstract class Human : IComparable<Human>
    {
        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        protected Human(string firstName, string lastName)
        {
            if (firstName == String.Empty || lastName == String.Empty)
            {
                throw new ArgumentException("The first and last names both must be filled");
            }
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int CompareTo(Human other)
        {
            int result = this.FirstName.CompareTo(other.FirstName);
            if (result == 0)
            {
                result = this.LastName.CompareTo(other.LastName);
            }
            return result;
        }

        public override string ToString()
        {
            return "I am " + this.FirstName + " " + this.LastName;
        }
    }
}
