using System.Collections.Generic;
using System;
using System.Linq;
// create a matrix of squares
class Matrix;

{
// public static int[,] Square(int[,] myMatrix)
    public static int[,] Square(int[,] myMatrix)
    
    {
        int[,] newMatrix = new int[myMatrix.GetLength(0), myMatrix.GetLength(1)];
        for (int zxy = 0; zxy < myMatrix.GetLength(0); zxy++) {
            for (int xyz = 0; xyz < myMatrix.GetLength(1); xyz++) {
                newMatrix[zxy, xyz] = myMatrix[zxy, xyz] * myMatrix[zxy, xyz];
            }
        }
        // return newMatrix;
        return newMatrix;
    }
}