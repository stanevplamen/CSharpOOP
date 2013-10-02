using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinarySearchTree;
using System.Collections.Generic;

namespace BinarySearchTreeUnitTest
{
    [TestClass]
    public class BSTUnitTest
    {
        [TestMethod]
        public void TestTree1() // Insert test
        {
            AATree<int, int> testedTreeOne = new AATree<int, int>();
            List<int> testListOne = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            for (int i = 0; i < testListOne.Count; i++)
            {
                bool sign = testedTreeOne.Add(testListOne[i], (i + 1));
                Assert.AreEqual(true, sign);
            }
        }

        [TestMethod]
        public void TestTree2() // Search test
        {
            AATree<int, int> testedTreeOne = new AATree<int, int>();
            List<int> testListOne = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            for (int i = 0; i < testListOne.Count; i++)
            {
                if (!testedTreeOne.Add(testListOne[i], (i + 1))) { };
            }

            for (int i = 0; i < testListOne.Count; i++)
            {
                bool sign = (testedTreeOne[testListOne[i]] != (i + 1));
                Assert.AreEqual(false, sign);
            }
        }

        [TestMethod]
        public void TestTree3() // Delete test
        {
            AATree<int, int> testedTreeOne = new AATree<int, int>();
            List<int> testListOne = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            for (int i = 0; i < testListOne.Count; i++)
            {
                if (!testedTreeOne.Add(testListOne[i], (i + 1))) { };
            }

            for (int i = 0; i < testListOne.Count; i++)
            {
                bool sign = testedTreeOne.Remove(testListOne[i]);
                Assert.AreEqual(true, sign);
            }
        }

        [TestMethod]
        public void TestTree4() // Clone, Equals and Operators test
        {
            AATree<int, int> testedTreeOne = new AATree<int, int>();
            AATree<int, int> testedTreeTwo = new AATree<int, int>();
            List<int> testListOne = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            for (int i = 0; i < testListOne.Count; i++)
            {
                if (!testedTreeOne.Add(testListOne[i], (i + 1))) { };
            }
            testedTreeTwo = testedTreeOne.Clone();

            bool sign = testedTreeOne == testedTreeTwo;
            Assert.AreEqual(true, sign);
            sign = testedTreeOne != testedTreeTwo;
            Assert.AreEqual(false, sign);


        }

        [TestMethod]
        public void TestTree5() // Equals and Operators test
        {
            AATree<int, int> testedTreeOne = new AATree<int, int>();
            AATree<int, int> testedTreeThree = new AATree<int, int>();
            List<int> testListOne = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            List<int> testListThree = new List<int>() { 1, 2, 3, 4, 5, 6, 20 };
            for (int i = 0; i < testListOne.Count; i++)
            {
                if (!testedTreeOne.Add(testListOne[i], (i + 1))) { };
            }
            for (int i = 0; i < testListThree.Count; i++)
            {
                if (!testedTreeThree.Add(testListThree[i], (i + 1))) { };
            }

            bool sign = testedTreeOne == testedTreeThree;
            Assert.AreEqual(false, sign);
            sign = testedTreeOne != testedTreeThree;
            Assert.AreEqual(true, sign);
        }

        [TestMethod]
        public void TestTree6() // Foreach test
        {
            AATree<int, int> testedTreeOne = new AATree<int, int>();
            List<int> testListOne = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            for (int i = 0; i < testListOne.Count; i++)
            {
                if (!testedTreeOne.Add(testListOne[i], (i + 1))) { };
            }
            int counter = 0;
            foreach (var node in testedTreeOne)
            {
                counter++;
            }
            Assert.AreEqual(counter, testListOne.Count);
        }
    }
}
