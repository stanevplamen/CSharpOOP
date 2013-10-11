using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLand
{
    public abstract class Pets : Animal, IComparable<Pets>
    {
        public int FrendlyIndex { get; protected set; }


        public Pets(string animalName, int age, string gender, string name, int frendlyIndex)
            : base(animalName, age, gender, name)
        {
            this.FrendlyIndex = frendlyIndex;
        }

        public override string ToString()
        {
            return "I am " + this.AnimalName;
        }

        public int CompareTo(Pets other)
        {
            return this.FrendlyIndex.CompareTo(other.FrendlyIndex);
        }
    }
}
