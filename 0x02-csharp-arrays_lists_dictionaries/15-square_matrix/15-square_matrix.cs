using System.Collections.Generic;
using System;
using System.Linq;

class Matrix;
{
    public static int[,] Square(int[,] myMatrix)
    {
       
        for (int i = 0; i < myMatrix.GetLength(0); i++) {
            for (int j = 0; j < myMatrix.GetLength(1); j++) {
                newMatrix[i, j] = myMatrix[i, j] * myMatrix[i, j];
            }
        }
        return newMatrix;
    }
}