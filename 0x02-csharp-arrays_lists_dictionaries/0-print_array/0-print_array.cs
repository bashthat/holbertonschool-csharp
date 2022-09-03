using System;

Class Array
{
    public static void Print(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (i == array.Length - 1)
            {
                Console.WriteLine(array[i]);
            }
            else
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}