using System;
using System.Collections.Generic;
// LList is a class
class LList
{
    // prototype to add all the values of a linked list
    public static int Sum(LinkedList<int> myLList)
    {
        int xyz = 0;
        foreach (int lit in myLList)
            xyz += lit;
        return xyz;
    }
} // word