using System;
using System.Collections.Generic;

class LList {
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> lint = myLList.First;
        while(lint != null)
        // null
        {
            if(lint.Value < n)
                lint = lint.Next;
            else
            // return lint
            {
                myLList.AddBefore(lint, n);
                return myLList.First;
            }   
        }
        // return myLList.First;
        
        myLList.AddLast(n);
        return myLList.First;  
    } // word
}