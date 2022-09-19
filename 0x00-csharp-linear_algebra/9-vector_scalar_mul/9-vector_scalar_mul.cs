using System.Collections.Generic;
using System;
using System.Numerics;
using MathNet.Numerics.LinearAlgebra;

/// <summary> class </summary>
class VectorMath
{
    /// <summary> multiplying a vector by a scalar </summary>
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Length == 2)
        {
            double[] result = new double[2];
            result[0] = vector[0] * scalar;
            result[1] = vector[1] * scalar;
            return result;
        }
        else if (vector.Length == 3)
        {
            double[] result = new double[3];
            result[0] = vector[0] * scalar;
            result[1] = vector[1] * scalar;
            result[2] = vector[2] * scalar;
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