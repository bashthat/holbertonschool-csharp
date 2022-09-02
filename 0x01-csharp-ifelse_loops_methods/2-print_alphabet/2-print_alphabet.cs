using System;
// printing the alphabet
class Program
{
    static void Main(string[] args)
    {
        char letter = 'a';
        while (letter <= 'z')
        {
            Console.Write(letter);
            letter++;
        }
        Console.WriteLine();
    }
}