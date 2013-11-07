using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyEcosystem
{
    public class Zombie : Animal
    {
        private const int startSize = 0;

        public Zombie(string name, Point location)
            : base(name, location, startSize)
        {
        }

        public override int GetMeatFromKillQuantity()
        {
            return 10;
        }
    }
}
