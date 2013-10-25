using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    public class Rectangle : Shape
    {
        public Rectangle(double Width, double Height)
            : base(Width, Height)
        {
        }

        public Rectangle()
        {
        }

        public override double CalculateSurface()
        {
            return this.Width * this.Height;
        }
    }
}
