using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLand
{
    public class Tomcat : Cat, ISound
    {
       #region Constructor

        public Tomcat(string animalName, int age, string gender, int frendlyIndex, string name)
            : base(animalName, age, gender, frendlyIndex, name)
        {
            this.Gender = "male";
        }

        #endregion

        #region Methods

        public string ProvideSound()
        {
            return "Tomi Miallyyyyyyy, Miallyyyyyyy";
        }

        #endregion
    }
}
