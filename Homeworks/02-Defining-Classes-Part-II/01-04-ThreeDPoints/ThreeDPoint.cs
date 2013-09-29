using System;
using System.Collections.Generic;

namespace ThreeDPoints
{
    public struct ThreeDPoint
    {
        #region Fields

        private double x;
        private double y;
        private double z;
        private static readonly ThreeDPoint csCenter;

        #endregion

        #region Properties

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public double Z
        {
            get { return z; }
            set { z = value; }
        }

        public static ThreeDPoint CSCenter
        {
            get
            {
                return csCenter;
            }
        }

        #endregion

        #region Constructors

        static ThreeDPoint()
        {
            csCenter = new ThreeDPoint(0.0, 0.0, 0.0);
        }

        public ThreeDPoint(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        #endregion

        #region Public Methods

        public override string ToString()
        {
            string outputStr = string.Format("The point coordinates (x,y,z) are: ({0},{1},{2})", X, Y, Z);
            return outputStr;
        }

        #endregion
    }
}
