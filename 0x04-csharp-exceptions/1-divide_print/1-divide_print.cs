using System;

// class Int create an integer

class Int 
{
    public static void divide(int a, int b) 
    // try to divide a by b
    // if b is 0, print Cannot divide by zero
    // if b is not an integer, print Cannot divide by non-number
    // if a or b is less than 0, print Cannot divide by negative number
    // finally, print a / b = result
    {
        try
        {
            Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        catch (FormatException)
        {
            Console.WriteLine("Cannot divide by non-number");
        }
        finally
        {
            if (a < 0 || b < 0)
            {
                Console.WriteLine("Cannot divide by negative number");
            }
        }
    }
