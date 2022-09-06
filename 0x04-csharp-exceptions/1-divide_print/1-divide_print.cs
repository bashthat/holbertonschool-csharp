using System.Collections.Generic;
using System;

class Int {
    public static void divide(int a, int b) {
        xyz = 0;
        try {
            xyz = a / b;
        } catch (DivideByZeroException) {
            Console.WriteLine("Cannot divide by zero");
        } finally {
            Console.WriteLine("{0} / {1} = {2}", a, b, xyz);
        }
    }
}