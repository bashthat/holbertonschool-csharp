using System.Collections.Generic;
using System;
// using System.Linq;
class Dictionary
{
    // Write a method that prints a Dictionary by ordered keys.
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        var sortedDict = myDict.K.OrderBy(x => x);
        foreach (var k in sorted)
        {
            Console.WriteLine($"{k}: {myDict[k]}");
            // return the sorted dictionary
        }
    }
} // end of class Dictionary