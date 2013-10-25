using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometricShapes;

namespace GeometricShapesUnitTest
{
    [TestClass]
    public class GeometricShapesTest
    {
        [TestMethod]
        public void TestShapes()
        {
            Shape[] shapesArray = new Shape[]
		    {
			    new Rectangle(2,3),
			    new Circle(5),
			    new Circle(2),
			    new Triangle(3,6),
			    new Triangle(4,7),
                new Square(4),
		    };

            Double[] testResultArray = { 6.00, 78.54, 12.57, 9.00, 14.00, 16.00 };
            int counter = 0;

            foreach (var sh in shapesArray)
            {
                Assert.AreEqual(testResultArray[counter], Math.Round(sh.CalculateSurface(), 2));
                counter++;
            }
        }
    }
}
