using System;
using System.Collections.Generic;


class List
{
    // Main Method
    public static int Sum(List<int> myList)
    {
        var sum = 0;
        hashset<int> num = new hashset<int>();
        // Iterate through the list
        foreach (int xyz in myList)
        {
            if (!hashset.Contains(xyz))
                {
                    hashset.Add(xyz);
                    sum += xyz;
                }
        }
        return (sum);
    }
}