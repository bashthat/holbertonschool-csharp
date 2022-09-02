using System;
using System.Collections.Generic;
class List
{
    // Main Method
    public static int Sum(List<int> myList) {
    }
        HashSet<int> mySet = new HashSet<int>();
        foreach (int y in myList)
        {
            mySet.Add(y);
        }
        int sum = 0;
        foreach (int y in mySet)
        {
            sum += y;
        }
        return sum;
    }
