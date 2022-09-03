using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System;
// class Dictionary<string, string>
class Dictionary
{
    public static Dictionary<string, string> AddKeyValue(Dictionary<string, string> myDict, string key, string value) {
       if (dsx.ContainsKey(key))
       // the key
       {
           dsx[key] = value;
       }
       // the value
       else
       {
           dsx.Add(key, value);
       }
    }
}