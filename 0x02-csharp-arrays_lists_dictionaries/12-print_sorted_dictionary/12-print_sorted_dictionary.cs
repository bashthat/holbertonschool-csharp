using System.Collections.Generic;
using System;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        var sortedDict = myDict.OrderBy(x => x.Key);
        foreach (KeyValuePair<string, string> entry in sortedDict)
        {
            Console.WriteLine("{0}: {1}", entry.Key, entry.Value);
        }
    }