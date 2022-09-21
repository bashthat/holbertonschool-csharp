using System;

/// <summary>Base an abstract class</summary>
public abstract class Base
{
    /// <summary>Property name</summary>
    public string name { get; set; }

    /// <summary>Override ToString method</summary>
    public override string ToString()
    {
        return $"{name} is a {this.GetType()}";
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
    /// <summary>Class Door</summary>
    public class Door : Base, IInteractive
    {
        /// <summary>Constructor</summary>
        public Door(string name = "Door")
        {
            this.name = name;
        }
        /// <summary>Method Interact</summary>
        public void Interact()
        {
            Console.WriteLine($"You try to open the {name}. It's locked.");
        }
    }