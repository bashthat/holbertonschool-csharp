using System.Collections.Generic;
using System;
/// <summary> class </summary>

class MatrixMath
{
    /// <summary> shears a square matrix </summary>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        double[,] newMatrix = new double[2, 2];
        double[,] errorMatrix = new double[,] {{-1}};
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return errorMatrix;
        if (direction == 'x')
        {
            newMatrix[0, 0] = matrix[0, 0] + (factor * matrix[0, 1]);
            newMatrix[0, 1] = matrix[0, 1];
            newMatrix[1, 0] = matrix[1, 0] + (factor * matrix[1, 1]);
            newMatrix[1, 1] = matrix[1, 1];
        }
        else if (direction == 'y')
        {
            newMatrix[0, 0] = matrix[0, 0];
            newMatrix[0, 1] = matrix[0, 1] + (factor * matrix[0, 0]);
            newMatrix[1, 0] = matrix[1, 0];
            newMatrix[1, 1] = matrix[1, 1] + (factor * matrix[1, 0]);
        }
        else
            return errorMatrix;
        return newMatrix;
    }
}