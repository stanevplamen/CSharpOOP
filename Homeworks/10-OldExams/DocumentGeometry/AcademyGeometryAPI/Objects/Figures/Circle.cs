using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyGeometryAPI
{
    public class Circle : Figure, IAreaMeasurable, IFlat
    {
        private double radius;

        public Vector3D Center
        {
            get { return this.vertices[0]; }
            set { this.vertices[0] = value; }
        }

        public double Radius
        {
            get { return this.radius; }
            private set { this.radius = value; }
        }

        public Circle(Vector3D center, double radius)
            : base(center)
        {
            this.Radius = radius;
        }

        public double GetArea()
        {
            double area = Math.Pow(Radius, 2) * Math.PI;
            return area;
        }

        public Vector3D GetNormal()
        {
            return new Vector3D(0, 0, 1);
        }

        public override double GetPrimaryMeasure()
        {
            return this.GetArea();
        }
    }
}
