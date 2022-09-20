using System.Runtime.InteropServices;
using System.Numerics;
using System;
using System.Collections.Generic;

/// <summary>Initializes Class Obj</summary>
class MatrixMath
{
    /// <summary>Method that transposes a matrix and returns the resulting matrix</summary>
    public static double[,] Transpose(double[,] matrix)
    {
        /// <summary>Transposes the matrix</summary>
        double[,] transposedMatrix = {};

        if (matrix == null || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0)
            return transposedMatrix;

            transposedMatrix[0] = new double[matrix.GetLength(0), matrix.GetLength(0)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    transposedMatrix[i, j] = matrix[j, i];
                }
            }
            /// <summary> returns the matrix transposed</summary>
            
            return transposedMatrix;
    }