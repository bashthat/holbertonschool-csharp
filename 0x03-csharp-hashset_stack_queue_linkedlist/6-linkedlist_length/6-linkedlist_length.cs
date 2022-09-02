using System;
using System.Collections.Generic;
// LLizst is a class
class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int xyz = 0;
        foreach (int vibe in myLList) {
            xyz++;
        }
        // returning the length of the linked list
        return xyz;
    }
}