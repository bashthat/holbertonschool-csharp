using System;

namespace Enemies
{
    /// <summary>Represents a zombie enemy.</summary>
    class Zombie
    {
        /// <summary> private field health.</summary>
        private int health;

        /// <summary> private field name.</summary>
        private string name = "(No name)";


        /// <summary>Initializes a new instance of the <see cref="Zombie"/> class.</summary>
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
        public int GetHealth()
        {
            return health;
        }
        public string Name { get; set; }


    }
}