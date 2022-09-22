﻿using System;

/// <summary>Base an abstract class</summary>

abstract class Base
{
    
    public string name = "";

    
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