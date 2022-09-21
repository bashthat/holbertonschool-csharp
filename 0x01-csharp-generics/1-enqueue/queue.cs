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

        public object value = null;
        public Node next = null;

        public object Value
        {
            get { return value; }
            set { this.value = value; }
        }
    }

    /// <summary>
    /// Adds a node to the end of the queue
    /// </summary>
    /// <returns>The new node</returns>
    
    public void Enqueue(T value)
    {
        /// <summary>
        /// Create a new node
        /// </summary>
        
        Node node = new Node();
        node.Value = value;

        if (head == null)
        {
            head = node;
            tail = node;
        }
        else
        {
            tail.next = node;
            tail = node;
        }

        count++;
    }
    /// <summary>Initializes Class Obj</summary>
    /// <returns>count</returns>

    public int Count()
    {
        return count;
    }
