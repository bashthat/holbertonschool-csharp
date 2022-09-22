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
    /// <summary> IInteractive </summary>
}
interface IInteractive
{
    void Interact();
}
/// <summary>IBreakable</summary>
interface IBreakable
{
    int durability { get; set; }
    void Break();
}
/// <summary>ICollectable</summary>
interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}
/// <summary>TestObject</summary>
class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int durability { get; set; }
    public bool isCollected { get; set; }

/// <summary>Interact</summary>

    public void Interact()
    {
    }

/// <summary>Break</summary>

    public void Break()
    {
    }

/// <summary>Collect</summary>

    public void Collect()
    {
    }
}