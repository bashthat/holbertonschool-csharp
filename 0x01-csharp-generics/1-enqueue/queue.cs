using System;

/// <summary>
/// Class Queue implementation
/// </summary>

class Queue<T>
{
    /// <summary>
    /// Check type of Queue
    /// </summary>
    
    /// <returns>Queue Type</returns>

    public Type CheckType()
    {
        return typeof(T);
    }
    
    /// <summary>
    /// Class Node implementation
    /// </summary>
    /// <returns>Node</returns>

    
    public class Node
    {
        public T value = default(T);
        public Node next = null;

        public Node(T t)
        {
            value = t;
        }
    }
    public Node head;
    public Node tail;
    public int standardCount;
    
    
    /// <summary>
    /// Method that creates a new Node @Queue.
    /// </summary>
    
    /// <param name="value">Value of the Node</param>
    
    /// <returns>Node</returns>


    public void Enqueue(T value)
    {
        Node newNode = new Node(value);
        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.next = newNode;
            tail = newNode;
        }
        standardCount++;
    }

    /// <summary>
    /// add new ndoe to the end of the queue
    /// </summary>
    /// <returns>the number of nodes in the queue</returns>
    
    public int Count()
    
    {
        return standardCount;
    }
}
