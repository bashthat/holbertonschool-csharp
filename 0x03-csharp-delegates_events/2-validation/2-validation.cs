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
    /// <summary>Initializes Class Obj</summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
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
        /// <summary> validate Hp </summary>
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
}