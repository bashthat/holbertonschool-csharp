using System.Collections.Generic;
using System;
/// <summary> class </summary>
class MatrixMath
{
    ///<summary> method </summary>
    public static double[,] Inverse2D(double[,] matrix)
    {
        double[,] result = new double[2, 2];
        double det = MatrixMath.Determinant(matrix);
        if (det == 0 || matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
            return new double[,] {{-1}};
        result[0, 0] = Math.Round(matrix[1, 1] / det, 2);
        result[0, 1] = Math.Round(-1 * matrix[0, 1] / det, 2);
        result[1, 0] = Math.Round(-1 * matrix[1, 0] / det, 2);
        result[1, 1] = Math.Round(matrix[0, 0] / det, 2);
        return result;
    }
}