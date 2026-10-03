/*
 * Author: Marco Gasperoni
 * Date:
 * Goal: Modelling my lamp class
 */ 

namespace BlaisePascal.Lesson1.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public class Enemy
    {
        // private: makes the value unaccessible from outside the class
        // int: states the value is an
        // _health: name of the attribute that indicates the enemy's health
        private int _health; // mutable

        // constant attributes
        private const int _maxHealth = 100; // constant that states the enemy's max health

        // Costruttore pubblico per istanziare un oggetto della classe Enemy
        public Enemy() { }
    }
}
