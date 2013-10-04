using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SBSubstrings;
using System.Text;

namespace SBSubstringUnitTest
{
    [TestClass]
    public class SBSubUnitTest
    {
        [TestMethod]
        public void TestSBSubstring1()
        {
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("Some words to be put into the string builder");

            StringBuilder sb2 = new StringBuilder();
            int startIndex = 5;
            int subLength = 5;
            sb2 = sb1.Substring(startIndex, subLength);

            Assert.AreEqual("words", sb2.ToString());
        }

        [TestMethod]
        public void TestSBSubstring2()
        {
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("Some words to be put into the string builder");

            StringBuilder sb2 = new StringBuilder();
            int startIndex = 0;
            int subLength = 44;
            sb2 = sb1.Substring(startIndex, subLength);

            Assert.AreEqual("Some words to be put into the string builder", sb2.ToString());
        }

        [TestMethod]
        public void TestSBSubstring3()
        {
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("Some words to be put into the string builder");

            StringBuilder sb2 = new StringBuilder();
            int startIndex = 0;
            int subLength = 5;
            sb2 = sb1.Substring(startIndex, subLength);

            Assert.AreEqual("Some ", sb2.ToString());
        }

        [TestMethod]
        public void TestSBSubstring4()
        {
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("Some words to be put into the string builder");

            StringBuilder sb2 = new StringBuilder();
            int startIndex = 37;
            int subLength = 7;
            sb2 = sb1.Substring(startIndex, subLength);

            Assert.AreEqual("builder", sb2.ToString());
        }
    }
}
