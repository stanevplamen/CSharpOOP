using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLand
{
    public abstract class Animal : IComparable<Animal>
    {
        public string AnimalName { get; set; }
        public int Age { get; set; }
        private string gender;
        private string name;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == String.Empty || value == null)
                {
                    throw new ArgumentOutOfRangeException("Invalid name");
                }
                this.name = value;
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
                if (value.ToLower() != "male" && value.ToLower() != "female")
                {
                    throw new ArgumentOutOfRangeException("Invalid gender");
                }
                this.gender = value;
            }
        }

        public Animal(string animalName, int age, string gender, string name)
        {
            this.AnimalName = animalName;
            this.Age = age;
            this.Gender = gender;
            this.Name = name;
        }

        public override string ToString()
        {
            return "I am " + this.AnimalName;
        }

        public int CompareTo(Animal other)
        {
            return this.Age.CompareTo(other.Age);
        }
    }
}
