using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System;
// class Dictionary<string, string>
class Dictionary
{
    public static Dictionary<string, string> AddKeyValue(Dictionary<string, string> myDict, string key, string value) {
        myDict.Add(key, value);
        // myDict.TryGetValue(key, out value);
        myDict.Remove(key);
        return myDict;
    }
}