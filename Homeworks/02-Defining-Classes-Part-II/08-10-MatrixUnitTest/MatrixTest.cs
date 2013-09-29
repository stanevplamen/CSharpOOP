using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MatrixT;

namespace MatrixUnitTest
{
    [TestClass]
    public class MatrixTest
    {
        [TestMethod]
        public void MatTest1()
        {
            Matrix<int> matrixOne = new Matrix<int>(Matrix<int>.matSize, Matrix<int>.matSize);
            Matrix<int> matrixTwo = new Matrix<int>(Matrix<int>.matSize, Matrix<int>.matSize);

            MatrixT.MatrixTest.InitMatrixInt(matrixOne);
            MatrixT.MatrixTest.InitMatrixInt(matrixTwo);

            Assert.AreEqual(matrixOne[3, 3], matrixTwo[3, 3]);
            Assert.AreEqual(matrixOne[1, 1], matrixTwo[1, 1]);
            Assert.AreEqual(matrixOne[3, 1], matrixTwo[3, 1]);
            Assert.AreEqual(matrixOne[1, 3], matrixTwo[1, 3]);
        }

        [TestMethod]
        public void MatTest2()
        {
            Matrix<int> matrixOne = new Matrix<int>(Matrix<int>.matSize, Matrix<int>.matSize);
            Matrix<int> matrixTwo = new Matrix<int>(Matrix<int>.matSize, Matrix<int>.matSize);

            MatrixT.MatrixTest.InitMatrixInt(matrixOne);
            MatrixT.MatrixTest.InitMatrixInt(matrixTwo);

            Matrix<int> matrixFour = matrixOne + matrixTwo;

            Assert.AreEqual(30, matrixFour[3, 3]);
            Assert.AreEqual(10, matrixFour[1, 1]);
            Assert.AreEqual(26, matrixFour[3, 1]);
            Assert.AreEqual(14, matrixFour[1, 3]);
        }

        [TestMethod]
        public void MatTest3()
        {
            Matrix<int> matrixOne = new Matrix<int>(Matrix<int>.matSize, Matrix<int>.matSize);
            Matrix<int> matrixTwo = new Matrix<int>(Matrix<int>.matSize, Matrix<int>.matSize);

            MatrixT.MatrixTest.InitMatrixInt(matrixOne);
            MatrixT.MatrixTest.InitMatrixInt(matrixTwo);

            Matrix<int> matrixFive = matrixOne - matrixTwo;

            Assert.AreEqual(0, matrixFive[3, 3]);
            Assert.AreEqual(0, matrixFive[1, 1]);
            Assert.AreEqual(0, matrixFive[3, 1]);
            Assert.AreEqual(0, matrixFive[1, 3]);
        }

        [TestMethod]
        public void MatTest4()
        {
            Matrix<int> matrixOne = new Matrix<int>(Matrix<int>.matSize, Matrix<int>.matSize);
            Matrix<int> matrixTwo = new Matrix<int>(Matrix<int>.matSize, Matrix<int>.matSize);

            MatrixT.MatrixTest.InitMatrixInt(matrixOne);
            MatrixT.MatrixTest.InitMatrixInt(matrixTwo);

            Matrix<int> matrixSix = matrixOne * matrixTwo;

            Assert.AreEqual(506, matrixSix[3, 3]);
            Assert.AreEqual(174, matrixSix[1, 1]);
            Assert.AreEqual(398, matrixSix[3, 1]);
            Assert.AreEqual(218, matrixSix[1, 3]);
        }
    }
}
