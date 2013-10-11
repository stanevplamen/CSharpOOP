using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject
{
    public class Person : Human
    {
        #region Private fields

        private int age;
        private string gender;
        private Fitness health;

        #endregion

        #region Properties

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0 || value > 120)
                {
                    throw new ArgumentOutOfRangeException("Invalid age.");
                }
                this.age = value;
            }
        }

        public string Gender
        {
            get
            {
                return this.gender;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Invalid gender.");
                }
                this.gender = value;
            }
        }

        public Fitness Health
        {
            get
            {
                return this.health;
            }
            set
            {
                if (value != null)
                {
                    this.health = value;
                }
                else
                {
                    this.health = Fitness.NotDefined;
                }
            }
        }

        #endregion

        #region Constructors

        public Person(string firstName, string lastName, int age, string gender, Fitness health)
            : base(firstName, lastName)
        {
            this.Age = age;
            this.Gender = gender;
            this.Health = health;
        }

        public Person(string firstName, string lastName, int age, string gender)
            : base(firstName, lastName)
        {
            this.Age = age;
            this.Gender = gender;
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return string.Format("Person details: {0} {1}, age={2}, gender - {3}, health condition - {4}", this.FirstName, this.LastName , this.age, this.gender, this.health);
        }

        #endregion
    }
}
