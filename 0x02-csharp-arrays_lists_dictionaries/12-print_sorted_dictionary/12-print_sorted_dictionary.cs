using System.Collections.Generic;
using System;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        var sortedDict = from entry in myDict orderby entry.Key select entry;
        foreach (KeyValuePair<string, string> entry in sortedDict)
        {
            Console.WriteLine("{0}: {1}", entry.Key, entry.Value);
        }
    }