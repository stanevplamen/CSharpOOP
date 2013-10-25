using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    public class Square : Rectangle
    {
        private double side;

        public double Side
        {
            get
            {
                return side;
            }
            set
            {
                side = value;
            }
        }

        public Square(double side)
        {
            this.Side = side;
        }

        public Square()
        {
        }

        public override double CalculateSurface()
        {
            return this.Side * this.Side;
        }
    }
}
