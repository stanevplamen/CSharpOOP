using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenericListNamespace;

namespace GenericListUnitTest
{
    [TestClass]
    public class GenericUnitTest
    {
        [TestMethod]
        public void TestList1()
        {
            GenericList<decimal> firstList = new GenericList<decimal>();
            firstList.Add(2.33m);
            firstList.Add(3.33m);
            firstList.Add(4.33m);
            firstList.Add(5.33m);

            Assert.AreEqual(5.33m, firstList[3]);
        }

        [TestMethod]
        public void TestList2()
        {
            GenericList<string> firstList = new GenericList<string>();
            firstList.Add("Ivan");
            firstList.Add("Anton");
            firstList.Add("Hristo");
            firstList.Add("Zet");

            Assert.AreEqual("Zet", firstList.Max<string>());
            Assert.AreEqual("Anton", firstList.Min<string>());
        }

        [TestMethod]
        public void TestList3()
        {
            GenericList<decimal> firstList = new GenericList<decimal>();
            firstList.Add(2.33m);
            firstList.Add(3.33m);
            firstList.Add(4.33m);
            firstList.Add(5.33m);

            firstList.InsertAt(6.33m, 33);

            Assert.AreEqual(6.33m, firstList[33]);
        }

        [TestMethod]
        public void TestList4()
        {
            GenericList<decimal> firstList = new GenericList<decimal>();
            firstList.Add(2.33m);
            firstList.Add(3.33m);
            firstList.Add(4.33m);
            firstList.Add(5.33m);

            firstList.RemoveAt(0);

            Assert.AreEqual(3.33m, firstList[0]);
        }

        [TestMethod]
        public void TestList5()
        {
            GenericList<decimal> firstList = new GenericList<decimal>(30);
            firstList.Add(2.33m);
            firstList.Add(3.33m);
            firstList.Add(4.33m);
            firstList.Add(5.33m);

            firstList[29] = 4.444m;

            Assert.AreEqual(4.444m, firstList[29]);
        }
    }
}
