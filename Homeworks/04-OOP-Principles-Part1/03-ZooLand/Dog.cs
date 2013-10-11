using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLand
{
    public class Dog : Pets, ISound
    {
        #region Constructor

        public Dog(string animalName, int age, string gender, int frendlyIndex, string name)
            : base(animalName, age, gender, name, frendlyIndex)
        {
            this.Gender = gender;
        }

        #endregion

        #region Methods

        public string ProvideSound()
        {
            return "Wof, Wof, Wof";
        }

        #endregion
    }
}
