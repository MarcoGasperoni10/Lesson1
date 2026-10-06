/*
 * Author: Marco Gasperoni
 * Date:
 * Goal: Modelling my lamp class
 */

using System.ComponentModel;

namespace BlaisePascal.Lesson1.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public class Enemy
    {
        // attributo
        private int _health;

        // proprietà
        // public int Health { get; set; } // forma abbreviata senza controlli
        public int Health { get; private set; }
        
        //public int Health
        //{
        //    get 
        //    {
        //        return _health;
        //    }
        //    set
        //    {
        //        if (value < 0) // caso limite 1
        //        {
        //            _health = 0;
        //        }
        //        else if (value > 100) // caso limite 2
        //        {
        //            _health = 100;
        //        }
        //        else // caso normale
        //        {
        //            _health = value;
        //        }
        //    }
        //}

        // costruttore
        public Enemy() { }

        public void SetHealth(int newHealth)
        {
            if (newHealth < 0)
                Health = 0;
            else if (newHealth > 100)
                Health = 100;
            else
                Health = newHealth;
        }

        public bool IsAlive()
        {
            return _health > 0;
        }

        public void TakeDamage(int damage)
        {
            if (damage < 0)
                damage = 0;
            SetHealth(_health - damage);
        }
    }
}