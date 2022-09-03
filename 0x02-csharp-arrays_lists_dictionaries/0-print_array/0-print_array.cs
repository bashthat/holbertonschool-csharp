using System;
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
            xyz[i] = i;
            if (i == size - 1) {
                Console.WriteLine(i);
            } else { // end if
                Console.Write("{0} ", i);
            }
        console.WriteLine();
        return xyz;
    }
}
}