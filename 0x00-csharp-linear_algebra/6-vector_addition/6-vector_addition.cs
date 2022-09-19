using System.Collections.Generic;
using System;
using System.Numerics;
using MathNet.Numerics.LinearAlgebra;


/// <summary> class </summary>
class VectorMath
{
    /// <summary> adding two vectors </summary>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if (vector1.Length == 2 && vector2.Length == 2)
        {
            double[] result = new double[2];
            result[0] = vector1[0] + vector2[0];
            result[1] = vector1[1] + vector2[1];
            return result;
        }
        else if (vector1.Length == 3 && vector2.Length == 3)
        {
            double[] result = new double[3];
            result[0] = vector1[0] + vector2[0];
            result[1] = vector1[1] + vector2[1];
            result[2] = vector1[2] + vector2[2];
            return result;
        }
        else
        {
            double[] result = new double[1];
            result[0] = -1;
            return result;
        }
    }
}