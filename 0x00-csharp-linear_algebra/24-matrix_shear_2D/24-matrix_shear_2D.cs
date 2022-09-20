using System.Collections.Generic;
using System;
/// <summary> class </summary>

class MatrixMath
{
    /// <summary> shears a square matrix </summary>
    /// method to shear
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
            double[,] output = new double[2, 2];
            double[,] shear = {{-1}};
            double[,] output2;

            if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
                return shear;
            if (direction == 'x')
            {
                shear = new double[,] {{1, factor}, {0, 1}};
                output2 = MatrixMath.Multiply(matrix, shear);
                return output2;
            }
            else if (direction == 'y')
            {
                shear = new double[,] {{1, 0}, {factor, 1}};
                output2 = MatrixMath.Multiply(matrix, shear);
                return output2;
            }
            else
                return shear;
            
    }
}