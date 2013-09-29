using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThreeDPoints;

namespace ThreeDPointsUnitTest
{
    [TestClass]
    public class ThreeDPointUnitTest
    {
        [TestMethod]
        public void TestPoints1()
        {
            ThreeDPoint newPointOne = new ThreeDPoint(1.0, 1.0, 1.0);
            ThreeDPoint newPointTwo = new ThreeDPoint();

            Assert.AreEqual("The point coordinates (x,y,z) are: (1,1,1)", newPointOne.ToString());
            Assert.AreEqual("The point coordinates (x,y,z) are: (0,0,0)", newPointTwo.ToString());
        }

        [TestMethod]
        public void TestPoints2()
        {
            ThreeDPoint systemCenter = ThreeDPoint.CSCenter;

            Assert.AreEqual(0, systemCenter.X);
            Assert.AreEqual(0, systemCenter.Y);
            Assert.AreEqual(0, systemCenter.Z);
        }

        [TestMethod]
        public void TestPoints3()
        {
            Path currentPath = new Path();

            ThreeDPoint newPoint = new ThreeDPoint(2.6, -5.5, 44.8);
            currentPath.AddPoint(newPoint);

            Assert.AreEqual(2.6, newPoint.X);
            Assert.AreEqual(-5.5, newPoint.Y);
            Assert.AreEqual(44.8, newPoint.Z);
        }

        [TestMethod]
        public void TestPoints4()
        {
            ThreeDPoint newPointOne = new ThreeDPoint(1.0, 1.0, 1.0);
            ThreeDPoint newPointTwo = new ThreeDPoint();
            double distanceOne = DistanceCalculator.Calculate3DDistance(newPointOne, newPointTwo);

            Assert.AreEqual(1.73, Math.Round(distanceOne, 2));
        }
    }
}
