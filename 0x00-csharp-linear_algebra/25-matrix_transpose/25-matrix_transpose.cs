using System;
using System.Collections.Generic;

/// <summary>Initializes Class Obj</summary>
class MatrixMath
{
    /// <summary>Method that transposes a matrix and returns the resulting matrix</summary>
    public static double[,] Transpose(double[,] matrix)
    {
        double[,] errorMatrix = new double[,] {{-1}};
        if (matrix.GetLength(0) != matrix.GetLength(1))
            return errorMatrix;
        double[,] newMatrix = new double[matrix.GetLength(0), matrix.GetLength(1)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                newMatrix[i, j] = matrix[j, i];
            }
        }
        return newMatrix;
    }
}