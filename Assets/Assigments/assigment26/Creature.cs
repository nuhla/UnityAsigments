using System.Collections;
using System.Collections.Generic;
using UnityEngine;



// Base Class:
// ● Create a class called Creature with a virtual method Speak().
// ● Speak() should use Debug.Log() to display a generic message, for example:
// "A creature makes a sound."

namespace Assigment26
{
    public class Creature
    {
        public virtual void Speak()
        {
            Debug.Log("A creature makes a sound.");
        }

    }
}