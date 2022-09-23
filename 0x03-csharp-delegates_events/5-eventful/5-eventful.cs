using System;
using System.Collections.Generic;

/// <summary> Initializes Class Obj</summary>


class Player
{
        
    private string name;
    private float maxHp;
    private float hp;
    private string status;
    
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
        this.status = $"{this.name} is ready to go!";
        HPCheck += CheckStatus;
    }
        /// <summary> Delegate method </summary>
        
        public void PrintHealth()
        {
            Console.WriteLine("{0} has {1} / {2} health", name, hp, maxHp);
        }


    
    public delegate int CalculateHealth(float damage);
    
    public void TakeDamage(float damage)
     {
        if (damage < 0f)
        {
            Console.WriteLine("{0} takes 0 damage!", this.name);
            damage = 0f;
        }
        else
            Console.WriteLine("{0} takes {1} damage!", this.name, damage);
        this.hp -= damage;
        ValidateHP(this.hp);
    }
    
    public void HealDamage(float heal)
    {
        if (heal < 0f)
        {
            Console.WriteLine("{0} heals 0 HP!", this.name);
            heal = 0f;
        }
        else
            Console.WriteLine("{0} heals {1} HP!", this.name, heal);
        this.hp += heal;
        ValidateHP(this.hp);
    }
    
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
        {
            hp = 0;
        }
        else if (newHp > maxHp)
        {
            hp = maxHp;
        }
        else
        {
            hp = newHp;
        }
        OnCheckStatus(new CurrentHPArgs(this.hp));
    }
    
    /// <summary> ApplyModifier </summary>
    public float ApplyModifier(float baseValue, Modifier modifier)
    
    {
        if (modifier == Modifier.Weak)
        {
            return baseValue / 2;
        }
        if (modifier == Modifier.Strong)
        {
            return baseValue * 1.5f;
        }
        return baseValue;
    }
    /// <summary> deligate Calculates health</summary>
    
    public event EventHandler<CurrentHPArgs> HPCheck;
    
    /// <summary> Initializes Check with</summary>
    
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == maxHp)
        {
            Console.WriteLine($"{name} is in perfect health!");
        }
        else if (e.currentHp >= maxHp / 2 && e.currentHp < maxHp)
        {
            Console.WriteLine($"{name} is doing well!");
        }
        else if (e.currentHp >= maxHp / 4 && e.currentHp < maxHp / 2)
        {
            Console.WriteLine($"{name} isn't doing too great...");
        }
        else if (e.currentHp > 0 && e.currentHp < maxHp / 4)
        {
            Console.WriteLine($"{name} needs help!");
        }
        
        else if (e.currentHp == 0)
        {
            Console.WriteLine($"{name} is knocked out!");
        }
    }

    private void HPValueWarning(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == 0)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Health has reached zero!");
            Console.ResetColor();
        }
        else
        {
            Console.WriteLine("Health is low");
        }
    }
    /// <summary> Check Status </summary>
    
    public void OnCheckStatus(CurrentHPArgs e)
    {
        if (e.currentHp < maxHp / 4)
            HPCheck += HPValueWarning;
        HPCheck(this, e);
    }

}

public delegate float CalculateModifier(float baseValue, Modifier modifier);


/// <summary> CurrentHP </summary>
public class CurrentHPArgs : EventArgs
{
    public readonly float currentHp;
    
     public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }
}
