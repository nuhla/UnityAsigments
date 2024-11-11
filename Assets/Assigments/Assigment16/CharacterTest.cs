using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment18
{
    /*1. Inside the same namespace, create a new class named CharacterTest that
    inherits from MonoBehaviour. This class will be attached to a GameObject in
    Unity to test the code.*/
    public class CharacterTest : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            /*2. In CharacterTest, create instances of Soldier and Officer and store them in a
            Character[] array. Use the parameterized constructor of Officer and non
            parameterized constructor of the Soldier to instantiate them.*/

            Officer officer = new Officer("halk", 90, new Position(30, 40));
            Soldier solder = new Soldier();

            Character[] charcters = { solder, officer };

            for (int i = 0; i < charcters.Length; i++)
            {
                charcters[i].DisplayInfo();
            }

            solder.Attack(50, officer);
            Debug.Log("===================================================");
            Debug.Log("==================== Affter Attack ================");
            Debug.Log("===================================================");
            for (int i = 0; i < charcters.Length; i++)
            {
                charcters[i].DisplayInfo();
            }
        }

        // Update is called once per frame

    }
}