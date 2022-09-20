using System.Collections.Generic;
using System;
/// <summary> class </summary>
class MatrixMath
{
    ///<summary> method </summary>
    public static double[,] Inverse2D(double[,] matrix)
    {
        int input_1 = matrix.GetLength(0);
        int input_2 = matrix.GetLength(1);
        double[,] output = new double[input_1, input_2];

        if (input_1 != 2 || input_2 != 2)
            return new double[,] {{-1}};

        double det = Math.Round((matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]), 2);
        if (det == 0)
            return new double[,] {{-1}};

        output[0, 0] = Math.Round(matrix[1, 1] / det, 2);
        output[0, 1] = Math.Round(-1 * matrix[0, 1] / det, 2);
        output[1, 0] = Math.Round(-1 * matrix[1, 0] / det, 2);
        output[1, 1] = Math.Round(matrix[0, 0] / det, 2);

        return output;
    }
}