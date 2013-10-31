using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonNS
{
    public class Person
    {
        #region Fields

        private const int minNameSymbols = 2;

        private string name;
        private int? age;

        #endregion

        #region Properties

        public string Name
        {
            get { return this.name; }
            set
            {
                if ((value != null && value.Length >= minNameSymbols) || value == null)
                {
                    this.name = value;
                }
                else
                {
                    throw new FormatException(String.Format("Invalid name {0}", this.name));
                }
            }
        }

        public int? Age
        {
            get { return this.age; }
            set
            {
                if ((value >= 0 && value < 120) || value == null)
                {
                    this.age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Invalid social sociaty number");
                }
            }
        }

        #endregion

        #region Constructors

        public Person(string name, int? age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Person(string name)
        {
            this.Name = name;
            this.Age = null;
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            if (Age == null)
            {
                return String.Format("Name: {0} Age: Unknown", this.Name);
            }
            else
            {
                return String.Format("Name: {0} Age: {1}", this.Name, this.Age);
            }
        }

        #endregion
    }
}
