using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyEcosystem
{
    public class Wolf : Animal, ICarnivore
    {
        private const int startSize = 4;

        public Wolf(string name, Point location)
            : base(name, location, startSize)
        {
        }

        public int TryEatAnimal(Animal animal)
        {
            if (animal != null && (animal.Size <= startSize || animal.State == AnimalState.Sleeping))
            {
                return animal.GetMeatFromKillQuantity();
            }
            else
            {
                return 0;
            }
        }
    }
}
