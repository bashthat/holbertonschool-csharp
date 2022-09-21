using System.Collections.Generic;
using System;
/// <summary> class </summary>
class MatrixMath
{
    /// <summary> method </summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        double[,] result = new double[2, 2];
        double[,] rotate = new double[2, 2] {{Math.Cos(angle), -Math.Sin(angle)}, {Math.Sin(angle), Math.Cos(angle)}};
        double[,] temp = new double[2, 2];
        double sum = 0;
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return new double[,] {{-1}};
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    sum += matrix[i, k] * rotate[k, j];
                }
                temp[i, j] = sum;
                sum = 0;
            }
        }
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                result[i, j] = Math.Round(temp[i, j], 2);
            }
        }
        return result;
    }
}