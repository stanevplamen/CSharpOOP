using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DivideBy;
using System.Linq;

namespace DivideByUnitTest
{
    [TestClass]
    public class DivideByTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] myArray = { 10, 20, 21, 42, 3, 5, 33, 233, 126, 1323, 378, 344 };
            //lambda
            int[] result1 = myArray.Where(x => x % 7 == 0 && x % 3 == 0).ToArray();

            int counter = 0;
            foreach (var item in myArray)
            {
                if (item % 21 == 0)
                {
                    Assert.AreEqual(item, result1[counter]);
                    counter++;
                }
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] myArray = { 10, 20, 21, 42, 3, 5, 33, 233, 126, 1323, 378, 344 };
            //linq
            int[] result2 = (from num in myArray where num % 7 == 0 && num % 3 == 0 select num).ToArray();

            int counter = 0;
            foreach (var item in myArray)
            {
                if (item % 21 == 0)
                {
                    Assert.AreEqual(item, result2[counter]);
                    counter++;
                }
            }
        }
    }
}
