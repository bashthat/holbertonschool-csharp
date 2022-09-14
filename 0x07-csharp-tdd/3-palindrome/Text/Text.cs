using System.Collections.Generic;
using System;

namespace Text
{
    /// <summary> creating a palindrome class </summary>
    public class Str
    {
        /// <summary> creating a palindrome class </summary>
        public static bool IsPalindrome(string s)
        {
            if (s == null)
                return false;
            s = s.ToLower();
            int i = 0;
            int j = s.Length - 1;
            while (i < j)
            {
                if (s[i] != s[j])
                    return false;
                i++;
                j--;
            }
            return true;
        }
    }
}