﻿using System;
using System.Collections.Generic;

class Player
{
    private string name;
    private float maxHp;
    private float hp;

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

    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }
}
    delegate void CalculateHealth(float amount);
    class CurrentHPArgs : EventArgs
    {
        public readonly float currentHp;
        public CurrentHPArgs(float newHp)
        {
            currentHp = newHp;
        }
    }
    