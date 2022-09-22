﻿using System;

/// <summary>Base an abstract class</summary>
/// <returns>Nothing</returns>
abstract class Base
{
    
    public string name = { get; set; }; 
    
    public override string ToString()
    {

        return (this.name + " is a " + this.GetType().ToString());
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

class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int durability { get; set; }
    public bool isCollected { get; set; }



    public void Interact()
    {
    }



    public void Break()
    {
    }



    public void Collect()
    {
    }
}