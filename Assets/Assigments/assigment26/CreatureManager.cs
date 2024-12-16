using System.Collections;
using System.Collections.Generic;
using Assigment26;
using UnityEngine;

namespace Assigment26
{
    public class CreatureManager : MonoBehaviour
    {
        // Start is called before the first frame update


        void Start()
        {

            //Create a list(e.g., List<Creature>) that contains one Kangaroo instance and
            // one Duck instance.
            List<Creature> creatures;
            Duck duck = new Duck();
            Kangaroo kangaroo = new Kangaroo();


            creatures = new List<Creature>() { kangaroo, duck };

            List<IRunnable> runnables;
            List<ISwimmable> swimmables;
            List<IJumpable> jumpables;

            //Create a list(e.g., List<Creature>) that contains one Kangaroo instance and
            // one Duck instance.
            // ○ Create separate lists for each interface: IRunnable, IJumpable, and
            // ISwimmable.
            // ○ Add the Kangaroo instance to both the IRunnable and IJumpable lists.
            // Add the Duck instance to both the IRunnable and ISwimmable lists.
            runnables = new List<IRunnable>() { kangaroo, duck };
            jumpables = new List<IJumpable>() { kangaroo };
            swimmables = new List<ISwimmable>() { duck };


            // For each creature(the Kangaroo and Duck), call Speak().
            Debug.Log("-----------------For each creature (the Kangaroo and Duck), call Speak().-----------");
            foreach (Creature creature in creatures)
            {
                creature.Speak();
            }


            // For each creature in IRunnable, call Run().
            Debug.Log("-----------------For each creature in IRunnable, call Run().-----------");
            foreach (IRunnable runnable in runnables)
            {
                runnable.Run();
            }

            // For each creature in IJumpable, call Jump().
            Debug.Log("-----------------For each creature in IJumpable, call Jump().-----------");
            foreach (IJumpable jumpable in jumpables)
            {
                jumpable.Jump();
            }


            // For each creature in ISwimmable, call Swim().
            Debug.Log("-----------------For each creature in ISwimmable, call Swim().-----------");
            foreach (ISwimmable swimmable in swimmables)
            {
                swimmable.Swim();
            }


        }

    }
}
