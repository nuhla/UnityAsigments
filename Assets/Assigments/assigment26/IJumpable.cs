using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Interfaces:
// ● Create three interfaces representing possible creature abilities:
// ○ IRunnable with a void Run() method.
// ○ IJumpable with a void Jump() method.
// ○ ISwimmable with a void Swim() method.

namespace Assigment26
{
    public interface IJumpable
    {
        public void Jump();
    }
}
