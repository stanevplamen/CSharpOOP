using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BitArray64NS;

namespace BitArray64NSUnitTest
{
    [TestClass]
    public class BitArrayTest
    {
        public static BitArray64 bits = new BitArray64();

        [TestMethod]
        public void BitArray64Test1() /// bit assign test
        {
            bits[0] = 1;

            Assert.AreEqual(0, bits[63]);
            Assert.AreEqual(1, bits[0]);
        }

        [TestMethod]
        public void BitArray64Test2() /// to string and indexes test
        {
            bits[0] = 1;
            string expectedAnswer = "Bits = 0000000000000000000000000000000000000000000000000000000000000001";

            Assert.AreEqual(expectedAnswer, bits.ToString());

            bits[63] = 1;
            expectedAnswer = "Bits = 1000000000000000000000000000000000000000000000000000000000000001";

            Assert.AreEqual(expectedAnswer, bits.ToString());
        }

        [TestMethod]
        public void BitArray64Test3() /// foreach(enumerable) and index test
        {
            bits[0] = 1;
            bits[10] = 1;
            bits[20] = 1;
            bits[63] = 1;

            int checkedIndex = 0;
            foreach (var bit in bits)
            {
                Assert.AreEqual(bit, bits[checkedIndex]);
                checkedIndex++;
            }
        }

        [TestMethod]
        public void BitArray64Test4() /// operators test
        {
            BitArray64 bits1 = new BitArray64();
            bits1[0] = 1;
            bits1[5] = 1;
            bits1[5] = 0;
            bits1[25] = 1;
            BitArray64 bits2 = new BitArray64();
            bits2[0] = 1;
            bits2[5] = 1;
            bits2[5] = 0;
            bits2[26] = 1;

            bool areEqualCheck = (bits1 == bits2);
            bool expectedAnswer = false;
            Assert.AreEqual(expectedAnswer, areEqualCheck);

            bits2[26] = 0;
            bits2[25] = 1;
            areEqualCheck = (bits1 == bits2);
            expectedAnswer = true;
            Assert.AreEqual(expectedAnswer, areEqualCheck);
        }
    }
}
