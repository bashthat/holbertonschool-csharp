using System.Collections.Generic;
using System;
/// <summary> class </summary>

class MatrixMath
{
    /// <summary> shears a square matrix </summary>
    /// method to shear
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        double[] result = new double[matrix.Length, direction, factor];
        double[,] output = new double[matrix.GetLength(0), matrix.GetLength(1)];

        if (matrix.GetLength(0) != matrix.GetLength(1))
            return new double[,] {{-1}};

        if (direction == 'x')
        {
            output[0, 0] = matrix[0, 0] + (matrix[0, 1] * factor);
            output[0, 1] = matrix[0, 1];
            output[1, 0] = matrix[1, 0] + (matrix[1, 1] * factor);
            output[1, 1] = matrix[1, 1];
        }
        else if (direction == 'y')
        {
            output[0, 0] = matrix[0, 0];
            output[0, 1] = matrix[0, 1] + (matrix[0, 0] * factor);
            output[1, 0] = matrix[1, 0];
            output[1, 1] = matrix[1, 1] + (matrix[1, 0] * factor);
        }
        else
            return new double[,] {{-1}};

        return output;
    }
}