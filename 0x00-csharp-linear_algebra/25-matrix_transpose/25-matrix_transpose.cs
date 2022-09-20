using System;
using System.Collections.Generic;

/// <summary>Initializes Class Obj</summary>
class MatrixMath
{
    /// <summary>Method that transposes a matrix and returns the resulting matrix</summary>
    public static double[,] Transpose(double[,] matrix)
    {
        int input_1 = matrix.GetLength(0);
        int input_2 = matrix.GetLength(1);
        double[,] output = new double[input_2, input_1];

        for (int i = 0; i < input_1; i++)
            for (int j = 0; j < input_2; j++)
                output[j, i] = matrix[i, j];
        
        return output;

    }
}