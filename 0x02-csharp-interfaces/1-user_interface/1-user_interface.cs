using System;

/// <summary>Base an abstract class</summary>
public abstract class Base
{
    /// <summary>Property name</summary>
    public string name = ""; 

    /// <summary>Override ToString method</summary>
    public override string ToString()
    {
        return $"{name} is a {this.GetType()}";
    }
}
    /// <summary>Interface IInteractive</summary>
    public interface IInteractive
    {
        /// <summary>Method Interact</summary>
        void Interact();
    }
    /// <summary>Interface IBreakable</summary>
    public interface IBreakable
    {
        /// <summary>Property durability</summary>
        int durability { get; set; }
        /// <summary>Method Break</summary>
        void Break();
    }
    /// <summary>Interface ICollectable</summary>
    public interface ICollectable
    {
        /// <summary>Property isCollected</summary>
        bool isCollected { get; set; }
        /// <summary>Method Collect</summary>
        void Collect();
    }
    /// <summary>Class TestObject</summary>
    public class TestObject : Base, IInteractive, IBreakable, ICollectable
    {
        /// <summary>Property durability</summary>
        public int durability { get; set; }
        /// <summary>Property isCollected</summary>
        public bool isCollected { get; set; }
        /// <summary>Method Interact</summary>
        public void Interact()
        {
        }
        /// <summary>Method Break</summary>
        public void Break()
        {
        }
        /// <summary>Method Collect</summary>
        public void Collect()
        {
        }
    }
