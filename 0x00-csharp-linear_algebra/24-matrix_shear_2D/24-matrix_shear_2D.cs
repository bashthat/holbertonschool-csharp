using System.Collections.Generic;
using System;
/// <summary> class </summary>

class MatrixMath
{
    /// <summary> shears a square matrix </summary>
    /// method to shear
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        double[,] result = new double[2, 2];
        double[,] shear = new double[2, 2];
        double[,] temp = new double[2, 2];
        double sum = 0;
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return new double[,] {{-1}};
        if (direction == 'x')
            shear = new double[2, 2] {{1, factor}, {0, 1}};
        else if (direction == 'y')
            shear = new double[2, 2] {{1, 0}, {factor, 1}};
        else
            return new double[,] {{-1}};
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    sum += matrix[i, k] * shear[k, j];
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