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
    /// <summary>Class Decoration</summary>
    public class Decoration : Base, IInteractive, IBreakable
    {
        /// <summary>Property durability</summary>
        public int durability { get; set; }
        /// <summary>Property isQuestItem</summary>
        public bool isQuestItem { get; set; }
        /// <summary>Constructor</summary>
        public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
        {
            if (durability < 0)
                throw new Exception("Durability must be greater than 0");
            this.name = name;
            this.durability = durability;
            this.isQuestItem = isQuestItem;
        }
        /// <summary>Method Interact</summary>
        public void Interact()
        {
            if (durability <= 0)
                Console.WriteLine($"The {name} has been broken.");
            else if (isQuestItem)
                Console.WriteLine($"You look at the {name}. There's a key inside.");
            else
                Console.WriteLine($"You look at the {name}. Not much to see here.");
        }
        /// <summary>Method Break</summary>
        public void Break()
        {
            durability--;
            if (durability > 0)
                Console.WriteLine($"You hit the {name}. It cracks.");
            else if (durability == 0)
                Console.WriteLine($"You smash the {name}. What a mess.");
            else
                Console.WriteLine($"The {name} is already broken.");
        
        }
        /// <summary>public bool is Question</summary>
        public bool isQuestItem { get; set; }

        /// <summary> a constructor</summary>
        public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
        {
            if (durability < 0)
                throw new Exception("Durability must be greater than 0");
            this.name = name;
            this.durability = durability;
            this.isQuestItem = isQuestItem;
        }

        if (durability <= 0)
            Console.WriteLine($"The {name} has been broken.");
        else if (isQuestItem)
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        else
            Console.WriteLine($"You look at the {name}. Not much to see here.");
    }
    /// <summary>Method Break</summary>
    public void Break()
    {
        durability--;
        if (durability > 0)
            Console.WriteLine($"You hit the {name}. It cracks.");
        else if (durability == 0)
            Console.WriteLine($"You smash the {name}. What a mess.");
        else
            Console.WriteLine($"The {name} is already broken.");
    }
}                                                