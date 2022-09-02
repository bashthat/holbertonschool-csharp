using System;
using System.Collections.Generic;
using System.Linq;
// LList is a class
class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        if (size < 0)
            size = 0;
        LinkedList<int> Lizst = new LinkedList<int>(Enumerable.Range(0, size));
        // Lizst = new LinkedList<int>(Enumerable.Range(0, size)); 
        foreach (int xyz in Lizst)
            Console.WriteLine(xyz);
        return Lizst;
    }
}