using System;
using System.Collections.Generic;
using System.Text;

namespace ThreeDPoints
{
    public class Path
    {
        public readonly HashSet<ThreeDPoint> SetOfPoints = new HashSet<ThreeDPoint>();

        public void AddPoint(ThreeDPoint point)
        {
            if (!SetOfPoints.Contains(point))
            {
                this.SetOfPoints.Add(point);
            }
        }

        public override string ToString()
        {
            StringBuilder outputSB = new StringBuilder();
            outputSB.AppendLine("Current points:");
            foreach (var point in SetOfPoints)
            {
                outputSB.AppendLine(point.ToString());
            }
            return outputSB.ToString();
        }
    }
}
