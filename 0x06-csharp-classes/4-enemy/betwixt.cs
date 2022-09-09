using System;

namespace Enemies
{
    /// <summary>Represents a Zombie Class.</summary>
    public class Zombie
    {
        /// <summary> private field health.</summary>
        private int health;

        /// <summary>Initializes the new instance <see cref="Zombie"/> class.</summary>
        public Zombie()
        {
            health = 0;
        }
    /// <summary>Initializing the new constructor of the <see cref="Zombie"/> class.</summary>
    
    /// <param name="value"></param>    
        
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
        /// <summary>Gets the health of the Zombie</summary>
	public int GetHealth()
        {
            return health;
        }
        /// <summary> getting and retrieving the set name through the public property Name </summary>
	public string Name { 
				get { return name; }
				set { name = value; }
	}

    }

}