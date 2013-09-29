using System;
using System.Collections.Generic;
using System.Text;


namespace MatrixT
{
    public class Matrix<T>
    where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        #region Fields 

        public const int matSize = 4;

        private int rows;
        private int cols;
        private T[,] matrix;

        #endregion

        #region Properties

        public int Rows
        {
            get
            {
                return rows;
            }
        }

        public int Cols
        {
            get
            {
                return cols;
            }
        }

        public T this[int x, int y]
        {
            get { return matrix[x, y]; }
            set { matrix[x, y] = value; }
        }

        #endregion

        #region Constructors

        public Matrix(int rows, int cols)
        {
            if (rows <= 0 || cols <= 0)
            {
                throw new ArgumentOutOfRangeException("Matrix dimensions must be positive integers.");
            }

            this.rows = rows;
            this.cols = cols;
            this.matrix = new T[rows, cols];
        }

        public Matrix(T[,] value)
        {
            if (value == null || value.GetLength(0) == 0 || value.GetLength(1) == 0)
            {
                throw new ArgumentOutOfRangeException("The two-dimensional initialization array must contain at least one item.");
            }

            this.rows = value.GetLength(0);
            this.cols = value.GetLength(1);
            matrix = (T[,])value.Clone();
        }     

        #endregion

        #region Methods

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            for (int x = 0; x < Matrix<T>.matSize; x++)
            {
                sb.Append("[ ");
                for (int y = 0; y < Matrix<T>.matSize; y++)
                {
                    string printer = Convert.ToString((matrix[x, y]));
                    sb.AppendFormat("{0,6},", printer);
                }
                sb.AppendLine("\b  ]");
            }
            sb.AppendLine();
            return sb.ToString();
        }

        #endregion

        #region Operators

        // add matrices
        public static Matrix<T> operator +(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            Matrix<T> matrixPlus = new Matrix<T>(matrixOne.rows, matrixOne.cols);
            if (matrixOne.rows == matrixTwo.rows && matrixOne.cols == matrixTwo.cols)
            {
                for (int x = 0; x < matSize; x++)
                {
                    for (int y = 0; y < matSize; y++)
                    {
                        matrixPlus[x, y] = (dynamic)matrixOne[x, y] + (dynamic)matrixTwo[x, y];
                    }
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException("Error in the matrix summing");
            }

            return matrixPlus;
        }

        // substract matrices
        public static Matrix<T> operator -(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            Matrix<T> matrixSubstract = new Matrix<T>(matrixOne.rows, matrixOne.cols);
            if (matrixOne.rows == matrixTwo.rows && matrixOne.cols == matrixTwo.cols)
            {
                for (int x = 0; x < matSize; x++)
                {
                    for (int y = 0; y < matSize; y++)
                    {
                        matrixSubstract[x, y] = (dynamic)matrixOne[x, y] - (dynamic)matrixTwo[x, y];
                    }
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException("Error in the matrix substraction");
            }
            return matrixSubstract;
        }

        // multiply matrices
        public static Matrix<T> operator *(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            Matrix<T> matrixMultiply = new Matrix<T>(matrixOne.rows, matrixTwo.cols);

            if (matrixOne.rows == matrixTwo.cols) // true
            {
                for (int i = 0; i < matSize; i++)
                {
                    for (int j = 0; j < matSize; j++)
                    {
                        for (int k = 0; k < matSize; k++)
                        {
                            matrixMultiply[i, j] = (dynamic)matrixMultiply[i, j] + (dynamic)matrixOne[i, k] * matrixTwo[k, j];

                        }
                    }
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException("The number of columns in Matrix1 is not equal to the number of rows in Matrix2.\n Therefore Multiplication of Matrix1 with Matrix2 is not possible");
            }
            return matrixMultiply;
        }

        public static bool operator true(Matrix<T> m)
        {
            if (m == null || m.rows == 0 || m.cols == 0)
            {
                return false;
            }

            for (int row = 0; row < m.rows; row++)
            {
                for (int col = 0; col < m.cols; col++)
                {
                    if (!m[row, col].Equals(default(T)))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool operator false(Matrix<T> m)
        {
            if (m == null || m.rows == 0 || m.cols == 0)
            {
                return true;
            }

            for (int row = 0; row < m.rows; row++)
            {
                for (int col = 0; col < m.cols; col++)
                {
                    if (!m[row, col].Equals(default(T)))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        #endregion

    }
}
