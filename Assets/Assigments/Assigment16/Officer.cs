
using UnityEngine;

namespace Assignment18
{
    public class Officer : Character
    {
        //2. Each class should have a parameterized constructor that calls the base
        //constructor to initialize the name, Health, and position.
        public Officer(string name, int health, Position position) : base(name, health, position) { }

        public Officer() : base() { }
        // Start is called before the first frame update

        //3. Override DisplayInfo in each child class to add Debug.Log(“Soldier”) for
        //Soldier class and Debug.Log(“Officer”) for Officer class in the beginning of the
        public override void DisplayInfo()
        {
            Debug.Log("officer");
            base.DisplayInfo();
        }
    }
}
