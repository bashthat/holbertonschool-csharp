using System;
using System.Collections.Generic;
/// <summary>
/// Delegate for calculating health
/// </summary>
/// <param name="amount">Amount to change health by</param>

class Player
{
    private string name;
    private float maxHp;
    private float hp;
    /// <summary>
    /// Constructor for Player class
    /// </summary>
    /// <param name="name">Name of player</param>
    public Player(string name="Player", float maxHp=100f)
    {
        if (maxHp <= 0)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            maxHp = 100f;
        }
        this.name = name;
        this.maxHp = maxHp;
        this.hp = maxHp;
    }
    /// <summary>Initializes Class Obj</summary>
    /// <param name="name">Name of Player</param>
    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }
}