using System;
using System.Collections.Generic;
// MyQueue
class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        Console.WriteLine("Number of items: {0}", aQueue.Count);
        if (aQueue.Count == 0)
            Console.WriteLine("Queue is empty");
        else
            Console.WriteLine("First item: {0}", aQueue.Peek());
        bool dynamic = aQueue.Contains(search); // bool dynamics
        Console.WriteLine("Queue contains \"{0}\": {1}", search, dynamic);
        if (dynamic) // if the search is found
        {
            string xyz;
            do {
                xyz = aQueue.Dequeue();
            }
            while (xyz != search);
        }
        aQueue.Enqueue(newItem);
        return aQueue;
     }
}
