using System;

namespace ThreeDPoints
{
    public class DistanceCalculator
    {     
        public static double Calculate3DDistance(ThreeDPoint a, ThreeDPoint b)
        {
            double result = Math.Sqrt(Math.Pow((a.X - b.X), 2) + Math.Pow((a.Y - b.Y), 2) + Math.Pow((a.Z - b.Z), 2));
            return result;
        }      
    }
}
