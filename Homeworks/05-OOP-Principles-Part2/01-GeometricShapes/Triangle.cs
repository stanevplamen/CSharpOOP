using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    public class Triangle : Shape
    {
        public Triangle(double Width, double Heigth)
            : base(Width, Heigth)
        {
        }

        public Triangle()
        {
        }

        public override double CalculateSurface()
        {
            return this.Width * this.Height / 2;
        }
    }
}
