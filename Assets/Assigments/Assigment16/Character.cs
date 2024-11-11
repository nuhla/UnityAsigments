
using UnityEngine;

using Assignment18;

// 1. Inside the namespace, create a base class named Character.
namespace Assignment18
{
    public class Character
    {
        //2. Add a public string name field, a private int health field, and a protected
        // Position position field of the struct type created above.

        public string name = "";
        private int health = 100;
        protected Position position;

        //3. Create a property for Health. Implement custom logic in the get and set to limit
        //the private field value health to a minimum 0 value or maximum 100 value.
        public int Health
        {
            get { return health; }
            set
            {
                if (value >= 100) health = 100;
                else if (value <= 0) health = 0;
                else { health = value; }
            }
        }

        /*4. Create two constructors; one parameterized constructor that initializes name,
        health, and position), and the other without parameters for Character.Use
        constructor chaining in the constructor without the parameter to call the
        parameterized constructor with default values
        : this( “No name”, 100, new Position(0,0,0)).*/

        public Character(string name, int health, Position position)
        {
            this.name = name;
            Health = health;
            this.position = position;
        }

        public Character() : this("New Character", 100, new Assignment18.Position(0, 0)) { }

        /*5. Create a virtual method named DisplayInfo that uses Debug.Log to display
        name, Health, and position (using the printPosition of the struct).*/
        public virtual void DisplayInfo()
        {
            Debug.Log("Charcter Name is :" + name + "\n Health : "
             + health);
            Debug.Log("position x ,y: " + position.x + " "
            + position.y);
        }
        /*6. Create two overloaded methods named Attack:
        a. One version takes two parameters; int damage and Character target
        b. The second version takes int damage, Character target and string
        attackType for example shooting or kicking, etc.
        c. Use the DRY (Do not repeat yourself) advice when writing these
        overloaded methods.*/

        public void Attack(int damage, Character enemy)
        {
            enemy.Health -= damage;
        }

        public void Attack(int damage, Character enemy, string attackType)
        {
            this.Attack(damage, enemy);
            string attack = attackType;

        }
    }




}