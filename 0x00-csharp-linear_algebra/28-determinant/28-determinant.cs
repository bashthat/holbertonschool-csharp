using System.Collections.Generic;
using System;

/// <summary> class </summary>
class MatrixMath

{
    ///<summary> method </summary>
    public static double Determinant(double[,] matrix)
    {
        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            return Math.Round((matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]), 2);
        }
        else if (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3)
        {
            double[,] temp = new double[2, 2];
            double sum = 0;
            double det = 0;
            for (int i = 0; i < 3; i++)
            {
                int tempI = 0;
                for (int j = 1; j < 3; j++)
                {
                    int tempJ = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        if (k == i)
                            continue;
                        temp[tempI, tempJ] = matrix[j, k];
                        tempJ++;
                    }
                    tempI++;
                }
                sum += matrix[0, i] * Determinant(temp);
                if (i % 2 == 1)
                    det -= sum;
                else
                    det += sum;
                sum = 0;
            }
            return Math.Round(det, 2);
        }
        else
            return -1;