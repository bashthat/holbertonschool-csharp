using System;
using System.Collections.Generic;
// LList is a class
class LList
{
    // prototype to get the node
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        // declaring the variable
        int xyz = 0;
        foreach (int lit in myLList)
        // foreach
        {
            if (xyz == n)
                return lit;
            xyz++;
        }
        // return -1;
        return 0;
    }
}