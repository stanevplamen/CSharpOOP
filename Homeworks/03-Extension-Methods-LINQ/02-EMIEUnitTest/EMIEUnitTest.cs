using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExtensionMethodsIE;
using System.Collections.Generic;

namespace ExtensionMethodsIEUnitTest
{
    [TestClass]
    public class EMIEUnitTest
    {
        [TestMethod]
        public void TestEMIE1()
        {        
            List<long> numbers = new List<long>() 
            { 1, 2, 3, 4, 5, 6, 44, -33, 22, 77, 8888, 44444, 232223, 442322324, 0, -33, -434, -4343, -4343, -44 };
            
            long sumSure = 0;
            long sumTest = numbers.Sum<long>();

            for (int i = 0; i < numbers.Count; i++)
            {
                sumSure = sumSure + numbers[i];
            }

            Assert.AreEqual(sumSure, sumTest);
        }

        [TestMethod]
        public void TestEMIE2()
        {
            List<long> numbers = new List<long>() 
            { 1, 2, 3, 4, 5, 6, 44, -33, 22, 77, 88, 44, 23, 44, 0, -33, -434, -3, -433, -4 };
            long productSure = 1;
            long productTest = numbers.Product<long>();

            for (int i = 0; i < numbers.Count; i++)
            {
                productSure = productSure * numbers[i];
            }

            Assert.AreEqual(productSure, productTest);
        }

        [TestMethod]
        public void TestEMIE3()
        {
            List<long> numbers = new List<long>() { 1, 2, 3, 4, 5, 6, 44, -33, 22, 77, 8888, 44444, 232223, 442322324, 0, -33, -434, -4343, -4343, -44 };

            long maxSure = 442322324l;
            long maxTest = numbers.Max<long>();

            Assert.AreEqual(maxSure, maxTest);
        }

        [TestMethod]
        public void TestEMIE4()
        {
            List<long> numbers = new List<long>() { 1, 2, 3, 4, 5, 6, 44, -33, 22, 77, 8888, 44444, 232223, 442322324, 0, -33, -434, -4343, -4343, -44 };

            long minSure = -4343;
            long minTest = numbers.Min<long>();

            Assert.AreEqual(minSure, minTest);
        }

        [TestMethod]
        public void TestEMIE5()
        {
            List<long> numbers = new List<long>() { 1, 2, 3, 4, 5, 6, 44, -33, 22, 77, 8888, 44444, 232223, 442322324, 0, -33, -434, -4343, -4343, -44 };

            double avrSure = numbers.Average();
            long avgTest = numbers.Average<long>();

            Assert.AreEqual((long)avrSure, avgTest);
        }

        [TestMethod]
        public void TestEMIE6()
        {
            List<string> strList = new List<string>() { "a", "b", "c", "z" };

            string sumTest = strList.Sum<string>();

            Assert.AreEqual("abcz", sumTest);
        }

        [TestMethod]
        public void TestEMIE7()
        {
            List<char> charList = new List<char>() { 'a', 'b', 'c', 'z' };
            char maxTest = charList.Max<char>();

            Assert.AreEqual('z', maxTest);
        }

        [TestMethod]
        public void TestEMIE8()
        {
            List<char> charList = new List<char>() { 'a', 'b', 'c', 'z' };
            char minTest = charList.Min<char>();

            Assert.AreEqual('a', minTest);
        }
    }
}
