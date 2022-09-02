using System;

class Program
{
    static void Main(string[] args)
    {
        for (int x = 0; x <= 98; x++)
        {
            Console.Write("{0:D2}, ", x);
        }
        Console.WriteLine("99");
    }
}