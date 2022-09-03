using System.Collections.Generic;
using System;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        foreach (KeyValuePair<string, string> entry in myDict.OrderBy(key => key.Key))
        {
            Console.WriteLine("{0}: {1}", entry.Key, entry.Value);
        }
    }
}