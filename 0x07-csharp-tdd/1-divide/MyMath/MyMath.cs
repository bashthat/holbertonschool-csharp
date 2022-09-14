using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary> creating a matrix with class </summary>
    public class Matrix
    {
        /// <summary> creating a matrix with class </summary>
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null)
                throw new ArgumentNullException("matrix");
            if (num == 0)
                throw new DivideByZeroException("num");
            int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    newMatrix[i, j] = matrix[i, j] / num;
                }
            }
            return newMatrix;
        }
    }
}