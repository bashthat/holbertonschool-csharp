using System;
using System.Collections.Generic;
// LLizst is a class
class LList
{
    // prototype to delete the node
    public static void Delete(LinkedList<int> myLList, int index)
    {
        LinkedListNode<int> dynamic = myLList.First;
        int x = 0;
        // declaring the variable
        while (dynamic != null)
        {
            if (x == index)
                myLList.Remove(node);
            dynamic = dynamic.Next;
            x++;
        // closing the while loop
        }
    }
}