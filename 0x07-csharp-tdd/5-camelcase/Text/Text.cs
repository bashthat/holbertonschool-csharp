using System.Collections.Generic;
using System;

namespace Text
{
    /// <summary> stringz </summary>
    public static int CamelCase(string s)
    {
        if (s == null)
            return 0;
        int count = 1;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] >= 'A' && s[i] <= 'Z')
                count++;
        }
        return count;
    }
    
}