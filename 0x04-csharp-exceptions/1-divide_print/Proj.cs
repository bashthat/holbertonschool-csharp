using System.Collections.Generic;
using System;

class Int {
    public static void divide(int a, int b) {
        try {
            Console.WriteLine(a / b);
        } catch (DivideByZeroException) {
            Console.WriteLine("Cannot divide by zero");
        }
        finally {
            Console.WriteLine("Inside divide");
        }
    }
}