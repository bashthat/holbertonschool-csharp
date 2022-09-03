using System.Collections.Generic;
using System;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList.Count == 0)
            return "None";
        int max = 0;
        string key = "";
        foreach (KeyValuePair<string, int> entry in myList)
        {
            if (entry.Value > max)
            {
                max = entry.Value;
                key = entry.Key;
            }
        }
        return key;
    }
}