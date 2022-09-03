using System.Collections.Generic;
using System;

namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[3, 3] {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
            Console.WriteLine(myArray[0, 0]);
            Console.WriteLine(myArray[0, 1]);
            Console.WriteLine(myArray[0, 2]);
            Console.WriteLine(myArray[1, 0]);
            Console.WriteLine(myArray[1, 1]);
            Console.WriteLine(myArray[1, 2]);
            Console.WriteLine(myArray[2, 0]);
            Console.WriteLine(myArray[2, 1]);
            Console.WriteLine(myArray[2, 2]);
        }
    }
}