using System.Collections.Generic;
using System;
// using System.Linq;
// create a matrix of squares
class Matrix;

{
// public static int[,] Square(int[,] myMatrix)
    public static int[,] Square(int[,] myMatrix)
    // create a new matrix 
    {
        int[,] newMatrix = new int[myMatrix.GetLength(0), myMatrix.GetLength(1)];
        for (int i = 0; i < myMatrix.GetLength(0); i++) {
            for (int q = 0; q < myMatrix.GetLength(1); q++) {
                newMatrix[i, q] = myMatrix[i, q] * myMatrix[i, q];
            }
        }
        // return newMatrix;
        return newMatrix;
    }
}