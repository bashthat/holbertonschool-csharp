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
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    myArray[i, j] = i * j;
                }
            } // for (int i = 0; i < 5; i++)
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                { // 0 0 0 0 0
                    Console.Write(myArray[i, j]);
                    if (j != 4)
                        Console.Write(" ");
                } // end for j
                Console.WriteLine();
            }
        }
    }
}