using System;
using System.Collections.Generic;
// LList is a class
class LList
{
    public static LinkedListNode<int> Add(LinkedList<int> myLList, int n)
    {
        myLList.AddFirst(new LinkedListNode<int>(n));
        return myLList.First;
    }
// closing the class
}