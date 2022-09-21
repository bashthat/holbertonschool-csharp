using System.Collections.Generic;
using System;
/// <summary> class </summary>
class MatrixMath
{
    /// <summary> Multiply a matrix by a scalar </summary>

    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            double[,] result = new double[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result[i, j] = matrix[i, j] * scalar;
                }
            }
            return result;
        }
        else if (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3)
        {
            double[,] result = new double[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    result[i, j] = matrix[i, j] * scalar;
                }
            }
            return result;
        }
        else
        {
            return new double[,] {{-1}};
        }
    }
}