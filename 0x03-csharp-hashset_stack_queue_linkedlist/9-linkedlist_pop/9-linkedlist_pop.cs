using System;
using System.Collections.Generic;
// LList is a class
class LList
{
    // prototype to delete the head node
    public static int Pop(LinkedList<int> myLList)
    {
        if (myLList.Count == 0) {
            // Console.WriteLine("LList is empty");
            return 0;
        }
        // returning the value
        int lint = myLList.First.Value;
        myLList.RemoveFirst();
        return lint;
     }
}