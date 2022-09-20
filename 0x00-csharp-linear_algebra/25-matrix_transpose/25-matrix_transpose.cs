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

            