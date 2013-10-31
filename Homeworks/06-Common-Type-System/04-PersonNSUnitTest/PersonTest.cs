using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonNS;

namespace PersonNSUnitTest
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void TestPersonNS1()
        {
            Person ivan1 = new Person("Ivan", 24);
            string expectedAnswer = "Name: Ivan Age: 24";

            Assert.AreEqual(expectedAnswer, ivan1.ToString());
        }

        [TestMethod]
        public void TestPersonNS2()
        {
            Person ivan1 = new Person("Ivan", 24);
            ivan1.Age = null;
            string expectedAnswer = "Name: Ivan Age: Unknown";

            Assert.AreEqual(expectedAnswer, ivan1.ToString());
        }

        [TestMethod]
        public void TestPersonNS3()
        {
            Person ivan2 = new Person("Ivan");
            string expectedAnswer = "Name: Ivan Age: Unknown";

            Assert.AreEqual(expectedAnswer, ivan2.ToString());
        }

        [TestMethod]
        public void TestPersonNS4()
        {
            Person ivan2 = new Person("Ivan");
            ivan2.Age = 44;
            string expectedAnswer = "Name: Ivan Age: 44";

            Assert.AreEqual(expectedAnswer, ivan2.ToString());
        }
    }
}
