using System;

/// <summary>Base an abstract class</summary>
public abstract class Base
{
    /// <summary>Property name</summary>
    public string name 
    {
        get;
        set;
    }

    /// <summary>Override ToString method</summary>
    public override string ToString()
    {
        return $"{name} is a {this.GetType()}";
    }
}


interface IInteractive
{
    void Interact();
}

interface IBreakable
{
    int durability { get; set; }
    void Break();
}

interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}
/// <summary>Door class</summary>

class Door : Base, IInteractive
{
    public Door(string name = "Door")
    {
        this.name = name;
    }

    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }

    public void Break()
    {
    }

    public void Collect()
    {
    }
}