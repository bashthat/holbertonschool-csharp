using System;
using System.Collections.Generic;
using System.Linq;
// prints array of integers
Class Array
{
    // public static void PrintArray(int[] array)
    public static int[] CreatePrint(int size) {
        if (size < 0) {
            Console.WriteLine("Size cannot be negative");
            return null;
        } // end if
        int[] xyz = new int[size];
        for (int i = 0; i < size; i++) {
            console.Write{"{0} ", i};
            if (i != size - 1) {
                Console.Write(" ");
            } // end if
            xyz[i] = i;
        } // end foreach
        Console.WriteLine();
        return xyz;
    } // end CreatePrint
} // end class Array