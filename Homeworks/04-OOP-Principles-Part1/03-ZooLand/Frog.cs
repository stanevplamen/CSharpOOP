using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLand
{
    public class Frog : Amphibians, ISound
    {
        public Frog(string animalName, int age, string gender, int hounrUnderWater, string name)
            : base(animalName, age, gender, name, hounrUnderWater)
        {
        }

        public string ProvideSound()
        {
            return "Kwack, Kwack, .... Kwack, Kwack";
        }
    }
}
