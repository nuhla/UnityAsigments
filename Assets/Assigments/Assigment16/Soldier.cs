
//1. Inside the namespace, create two classes, Soldier and Officer, that inherit from
//Character.
using UnityEngine;

namespace Assignment18
{
    public class Soldier : Character
    {
        //2. Each class should have a parameterized constructor that calls the base
        //constructor to initialize the name, Health, and position.
        public Soldier(string name, int health, Position position) : base(name, health, position) { }
        public Soldier() : base() { }

        /*3. Override DisplayInfo in each child class to add Debug.Log(“Soldier”) for
        Soldier class and Debug.Log(“Officer”) for Officer class in the beginning of the
        method then call the base method using base.DisplayInfo() which calls the
        base method in the Character class from its child.*/
        public override void DisplayInfo()
        {
            Debug.Log("Soldier");
            base.DisplayInfo();
        }
    }
}
