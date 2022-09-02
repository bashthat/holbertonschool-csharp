using System;
using System.Collections.Generic;
class List
{
    // Main Method
    public static int Sum(List<int> myList) {
        var hashset = new List<int>();
        var sum = 0;
        // Iterate through the list
        foreach (var xyz in myList)
        {
            if (!hashset.Contains(xyz))
                hashset.Add(xyz);
        }
        // Iterate through the hashset
        foreach (var xyz in hashset)
                sum += xyz;
        return (sum);
    }
}