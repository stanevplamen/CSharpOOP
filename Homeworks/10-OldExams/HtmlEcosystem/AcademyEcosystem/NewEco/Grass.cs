using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyEcosystem
{
    public class Grass : Plant
    {
        private const int startSize = 2;

        public Grass(Point location)
            : base(location, startSize)
        {
        }

        public override void Update(int timeElapsed)
        {
            if (this.IsAlive)
            {
                this.Size += timeElapsed;
            }
        }
    }
}
