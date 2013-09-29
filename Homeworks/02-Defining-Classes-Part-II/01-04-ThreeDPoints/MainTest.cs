using System;
using System.Collections.Generic;

namespace ThreeDPoints
{
    class MainTest
    {
        public static Path currentPath = new Path();

        static void Main()
        {
            // 1
            ThreeDPoint newPointOne = new ThreeDPoint(1.0, 1.0, 1.0);
            Console.WriteLine(newPointOne.ToString());
            // 2
            ThreeDPoint newPointTwo = new ThreeDPoint();
            Console.WriteLine(newPointTwo.ToString());
            // 3
            double distanceOne = DistanceCalculator.Calculate3DDistance(newPointOne, newPointTwo);
            Console.WriteLine("The distance is {0:0.000}", distanceOne);
            // 4
            // add some points manually
            currentPath.AddPoint(newPointOne);
            currentPath.AddPoint(newPointTwo);
            Console.WriteLine(currentPath.ToString());
            // add some points from text
            PathStorage.ReadPathPoints();
            Console.WriteLine(currentPath.ToString());
            PathStorage.WritePathPoints(currentPath);
        }
    }
}
