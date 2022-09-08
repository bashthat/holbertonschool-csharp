using System;

namespace Enemies
{
    /// <summary>Zombie Class, aka the enemy.</summary>
    class Zombie
    {
        /// <summary> public field health.</summary>
        public int health;

        /// <summary>Initializes the new instance of a<see cref="Zombie"/> class.</summary>
        public Zombie()
        {
            health = 0;
        }
    /// <summary>Initializing the new constructor of the <see cref="Zombie"/> class.</summary>
        
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            else
            {
                health = value;
            }
        }
    }
}