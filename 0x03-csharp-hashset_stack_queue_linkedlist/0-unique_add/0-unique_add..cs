using System;
using System.Collections.Generic;
class List
{
    // Main Method
    public static int Sum(List<int> myList) {
        var sum = 0;
        var unique = new HashSet<int>();

        foreach (var item in myList) {
            if (unique.Add(item)) {
                sum += item;
            }
        }
        return sum;
    }
}