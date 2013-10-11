using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLand
{
    public abstract class Amphibians : Animal, IComparable<Amphibians>
    {
        public int HounrUnderWater { get; protected set; }

        public Amphibians(string animalName, int age, string gender, string name, int hounrUnderWater)
            : base(animalName, age, gender, name)
        {
            this.HounrUnderWater = hounrUnderWater;
        }

        public override string ToString()
        {
            return "I am " + this.AnimalName;
        }

        public int CompareTo(Amphibians other)
        {
            return this.HounrUnderWater.CompareTo(other.HounrUnderWater);
        }
    }
}
