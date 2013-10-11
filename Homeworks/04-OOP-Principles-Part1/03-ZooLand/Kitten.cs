using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLand
{
    public class Kitten : Cat, ISound
    {

       #region Constructor

        public Kitten(string animalName, int age, string gender, int frendlyIndex, string name)
            : base(animalName, age, gender, frendlyIndex, name)
        {
            this.Gender = "female";
        }

        #endregion

        #region Methods

        public string ProvideSound()
        {
            return "Kiti Miallyyyyyyy, Miallyyyyyyy";
        }

        #endregion
    }
}
