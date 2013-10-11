using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLand
{
    public class Cat : Pets, ISound
    {
        #region Constructor

        public Cat(string animalName, int age, string gender, int frendlyIndex, string name)
            : base(animalName, age, gender, name, frendlyIndex)
        {
            this.Gender = gender;
        }

        #endregion

        #region Methods

        public string ProvideSound()
        {
            return "Miallyyyyyyy";
        }

        #endregion
    }
}
