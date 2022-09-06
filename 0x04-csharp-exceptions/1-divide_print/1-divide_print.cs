using System;

// class Int create an integer

class Int 
{
    public static void divide(int a, int b) 
    
        // try to divide a by b
        // if a or b are equal to zero then print "Cannot divide by zero"
    
    {
        try
        {
            Console.WriteLine(a / b);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
        }
    }
}
