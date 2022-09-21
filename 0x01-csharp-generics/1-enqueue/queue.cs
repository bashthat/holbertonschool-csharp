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
}
    
    /// <summary>
    /// Class Node
    /// </summary>
    
    public class Node
    {
        /// <summary>
        /// value: can be of any type,
        /// next: must be an object of type Node
        /// </summary>

        public string value = null;
        public Node next = null;

    public Node(string str)
    {
        value = str;
    }
    /// <summary>
    /// Adds a node to the end of the queue
    /// </summary>
    
    public void Enqueue(Node node)
    {
        if (head == null)
        {
            head = node;
            return;
        }
        Node current = head;
        while (current.next != null)
        {
            current = current.next;
        }
        current.next = node;
    }
    
    /// <summary>Initializes Class Obj</summary>
    /// <returns>counts</returns>

    public int Count()
    {
        return count;
    }
