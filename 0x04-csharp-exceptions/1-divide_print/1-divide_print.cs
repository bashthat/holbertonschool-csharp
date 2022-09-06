using System;

// class Int create an integer

class Int 
{
    public static void divide(int a, int b) 
    
        // try to divide a by b
        // if a or b are equal to zero then print "Cannot divide by zero"
    {
        int xyz = 0;
        // more literal syntax
        try
        {
            xyz = a / b;
        }
        catch (System.DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            // Console.WriteLine("{0} / {1} = {2}", a, b, xyz);
            Console.WriteLine($"{a} / {b} = {xyz}");
        }
    }
} // wroks
