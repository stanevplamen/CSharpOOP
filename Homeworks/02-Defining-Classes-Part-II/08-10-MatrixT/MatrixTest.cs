using System;
using System.Collections.Generic;

namespace MatrixT
{
    public class MatrixTest
    {
        static void Main()
        {
            // 08
            Matrix<int> matrixOne = new Matrix<int>(Matrix<int>.matSize, Matrix<int>.matSize);
            Matrix<int> matrixTwo = new Matrix<int>(Matrix<int>.matSize, Matrix<int>.matSize);
            Matrix<double> matrixThree = new Matrix<double>(Matrix<int>.matSize, Matrix<int>.matSize);

            // initialize matrices 
            InitMatrixInt(matrixOne);
            InitMatrixInt(matrixTwo);
            InitMatrixDouble(matrixThree);

            Console.WriteLine(matrixOne.ToString());
            Console.WriteLine(matrixThree.ToString());

            // 09
            int testInt = matrixOne[1, 1];
            double testDob = matrixThree[1, 1];

            Console.WriteLine("{0} / {1}", testInt, testDob);

            // 10 
            // perform operation and print out results
            Matrix<int> matrixFour = matrixOne + matrixTwo;
            Matrix<int> matrixFive = matrixOne - matrixTwo;
            Matrix<int> matrixSix = matrixOne * matrixTwo;

            Console.WriteLine();
            Console.WriteLine("Matrix 1 + Matrix 2 = ");
            Console.WriteLine(matrixFour.ToString());

            Console.WriteLine();
            Console.WriteLine("Matrix 1 - Matrix 2 = ");
            Console.WriteLine(matrixFive.ToString());

            Console.WriteLine();
            Console.WriteLine("Matrix 1 * Matrix 2 = ");
            Console.WriteLine(matrixSix.ToString());

            if (matrixFour)
            {
                Console.WriteLine("The matrix contains non-zero items.");
            }
        }

        // initialize matrix with values
        public static void InitMatrixInt(Matrix<int> mat)
        {
            int counterOne = 0;
            for (int x = 0; x < Matrix<int>.matSize; x++)
            {
                for (int y = 0; y < Matrix<int>.matSize; y++)
                {
                    mat[x, y] = counterOne;
                    counterOne++;
                }
            }
        }

        public static void InitMatrixDouble(Matrix<double> mat)
        {
            double counterOne = 0.0;
            for (int x = 0; x < Matrix<int>.matSize; x++)
            {
                for (int y = 0; y < Matrix<int>.matSize; y++)
                {
                    mat[x, y] = counterOne;
                    counterOne = counterOne + 3.14;
                }
            }
        }
    }
}
