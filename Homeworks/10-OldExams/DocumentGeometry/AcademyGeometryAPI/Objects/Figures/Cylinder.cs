using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyGeometryAPI
{
    public class Cylinder : Figure, IAreaMeasurable, IVolumeMeasurable
    {
        private double radius;

        public Vector3D CenterBottom
        {
            get { return this.vertices[0]; }
            set { this.vertices[0] = value; }
        }

        public Vector3D CenterTop
        {
            get { return this.vertices[1]; }
            set { this.vertices[1] = value; }
        }

        public double Radius
        {
            get { return this.radius; }
            private set { this.radius = value; }
        }

        public Cylinder(Vector3D bottom, Vector3D top, double radius)
            : base(bottom, top)
        {
            this.Radius = radius;
        }

        public double GetArea()
        {
            double height = this.GetHeight();

            return 2 * Math.PI * this.Radius * (this.Radius + height);
        }

        public double GetVolume()
        {
            double height = this.GetHeight();

            return Math.PI * this.Radius * this.Radius * height;
        }

        private double GetHeight()
        {
            return (this.vertices[0] - this.vertices[1]).Magnitude;
        }

        public override double GetPrimaryMeasure()
        {
            return this.GetVolume();
        }
    }
}
