using System;
using System.Collections.Generic;


class List
{
    // Main Method
    public static int Sum(List<int> myList) {
    }
        int sum = 0;
	HashSet<int> set = new HashSet<int>(myList);
        foreach (int y in set)
        // keep it simple
        {
            sum += y;
        }
        // return the sum
	return sum;
    }
