using System;

// class Int create an integer

class Int 
{
    public static void divide(int a, int b) 
    {
        print = 0;
        try 
        {
            print = a / b;
        } catch (DivideByZeroException) 
        {
            Console.WriteLine("Cannot divide by zero");
        } finally 
        // spacing
        {
            Console.WriteLine("{0} / {1} = {2}", a, b, print);
        }
    }
}
