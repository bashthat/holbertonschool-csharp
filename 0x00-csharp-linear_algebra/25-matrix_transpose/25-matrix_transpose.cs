using System;
using System.Collections.Generic;

/// <summary>Initializes Class Obj</summary>
class MatrixMath
{
    /// <summary>Method that transposes a matrix and returns the resulting matrix</summary>
    public static double[,] Transpose(double[,] matrix)
    {
        double[,] transposedMatrix = new double[matrix.GetLength(1), matrix.GetLength(0)];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)

            {
                transposedMatrix[j, i] = matrix[i, j];
            }
        }
        return transposedMatrix;
    }
}