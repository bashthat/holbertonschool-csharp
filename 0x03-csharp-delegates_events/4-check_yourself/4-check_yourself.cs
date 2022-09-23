using System.Security.AccessControl;
using System;
using System.Collections.Generic;

/// <summary>
/// Delegate for calculating health
/// </summary>


class Player
{
        
    private string name;
    private float maxHp;
    private float hp;
    /// <summary>Initializes Class Obj</summary>
    /// <param name="name">Name</param>
    /// <param name="maxHp">Max HP</param>

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

    
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == this.maxHp)
        {
            Console.WriteLine($"{this.name} is in perfect health!");
        }
        else if (e.currentHp >= this.maxHp / 2 && e.currentHp <= this.maxHp / 2)
        {
            Console.WriteLine($"{this.name} is doing well!");
        }
        else if (e.currentHp >= this.maxHp / 4 && e.currentHp <= this.maxHp / 4)
        {
            Console.WriteLine($"{this.name} isn't doing too great...");
        }
        else if (e.currentHp > 0 && e.currentHp <= this.maxHp / 4) 
        {
            Console.WriteLine($"{this.name} needs help!");
        }
        else
        {
            Console.WriteLine($"{this.name} is knocked out!");
        }


    }
    
    
    /// <summary>Initializes Class Obj</summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {this.hp} / {maxHp} health");
    }

    /// <summary> deligate Calculates health</summary>
    /// <param name="damage">Damage</param>
    
    delegate float CalculateHealth(float damage);

    /// <summary>Take Damage</summary>
    /// <param name="damage">Damage</param>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            damage = 0;
        }
        float newHp = this.hp - damage;

        

        ValidateHP(newHp);

       

        System.Console.WriteLine($"{name} takes {damage} damage!");
    }
    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            heal = 0;
        }

        float newHp = this.hp + heal;
        
        ValidateHP(newHp);

       
        System.Console.WriteLine($"{name} heals {heal} HP!");

    }
    /// <summary> ValidateHp </summary>

    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
        {
            newHp = 0;
        }   
        if (newHp > maxHp)
        {
            newHp = maxHp;
        }
        else
        {
            hp = newHp;
        }
    }
/// <summary> ApplyModifier class </summary>
    /// <param name="baseValue">Base Value</param>
    /// <param name="modifier">Modifier</param>
    /// <returns>Modifier</returns>
    
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
        {
            return baseValue * 0.5f;
        }
        else if (modifier == Modifier.Base)
        {
            return baseValue;
        }
        else
        {
            return baseValue * 1.5f;
        }
    }
}

/// <summary> Enum health values.</summary>

public enum Modifier
{
    /// <summary> Weak </summary>
    Weak,
    /// <summary> Base </summary>
    Base,
    /// <summary> Strong </summary>
    Strong
}

/// <summary> Delegate methods for Health values.</summary>
/// <param name="baseValue">Base Value</param>
/// <param name="modifier">Modifier</param>
/// <returns>Modifier</returns>

public delegate float CalculateModifier(float baseValue, Modifier modifier);

class CurrentHPArgs : EventArgs
{
    public readonly float currentHp;
    public CurrentHPArgs(float newHp)
    {
        currentHp = newHp;
    }
}