using System.Collections.Generic;
using System;

class Dictionary
{
    public static Dictionary<string, string> AddKeyValue(Dictionary<string, string> myDict, string key, string value) {
        myDict.Add(key, value);
        return myDict;
    }
}