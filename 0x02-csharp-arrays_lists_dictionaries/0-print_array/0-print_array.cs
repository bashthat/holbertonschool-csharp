using System;
// prints array of integers
Class Array
{
    // public static void PrintArray(int[] array)
    public static int[] CreatePrint(int size) {
        if (size < 0) {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        int[] array = new int[size];
        for (int i = 0; i < size; i++) {
            array[i] = i;
            if (i == size - 1) {
                Console.WriteLine(i);
            } else {
                Console.Write(i + " ");
            }
        }
        return array;
    }
}