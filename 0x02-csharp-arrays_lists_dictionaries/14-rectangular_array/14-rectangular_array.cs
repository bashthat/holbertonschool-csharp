using Internal;
using System.Collections.Generic;
using System;
// class Dictionary<string, string>
namespace _14_rectangular_array
{ 
    class Program
    // class 
    { 
        static void Main(string[] args)
        {
            int[,] myArray = new int[5, 5];
            array[2, 2] = 1;
            for (int i = 0; i < myArray.GetLength; i++)
            {
                for (int j = 0; j < myArray.GetLength; j++)
                {
                    Console.Write(myArray[i, j]);
                    // myArray[i, j] = i * j;
                    // Console.Write(myArray[i, j]);
                    if (j < myArray.GetLength(1) - 1)
                    {
                        Console.Write(" ");
                    } // end
                }
            } // for (int i = 0; i < 5; i++)
            Console.WriteLine();
            //  0 0 0 0 0
        } // static void Main(string[] args)
    } // class Program
} // namespace _14_rectangular_array
