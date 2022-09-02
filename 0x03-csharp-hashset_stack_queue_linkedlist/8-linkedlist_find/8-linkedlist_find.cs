using System;
using System.Collections.Generic;
// LLizst is a class
class LList
{
    // prototype to find the node
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int xyz = 0;
        foreach (int queue in myLList)
        {
            if (queue == value)
                return xyz;
            xyz++;
        }
        return -1;
    // return -1;
    }
}