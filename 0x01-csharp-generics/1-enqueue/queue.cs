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
    
    public class Node
    
    {
        public object value = null;
        public Node next = null;

        public object value
        {
            get; { return value; }
            set; { this.value = value; }
        }
    }
        /// <summary>Initializes Class Obj</summary>
        public Queue()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }
        /// <summary>Initializes Class Obj</summary>
        public int count()
        {
            return this.count;
        }
        /// <summary>Initializes Class Obj</summary>
        public Node head()
        {
            return this.head;
        }
        /// <summary>Initializes Class Obj</summary>
        public Node tail()
        {
            return this.tail;
        }
        /// <summary>Initializes Class Obj</summary>
        public void Enqueue(T value)
        {
            Node new_node = new Node();
            new_node.value = value;
            if (this.head == null)
            {
                this.head = new_node;
                this.tail = new_node;
            }
            else
            {
                this.tail.next = new_node;
                this.tail = new_node;
            }
            this.count++;
        }
}

    
