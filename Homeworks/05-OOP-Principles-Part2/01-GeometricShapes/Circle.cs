using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    public class Circle : Shape
    {
        private double radius;

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public Circle()
        {
        }

        public override double CalculateSurface()
        {
            return Math.PI * this.Radius * this.Radius;
        }
    }
}
