using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assigment29.Part2
{
    public class TestClass : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {


            CustomObject a = new CustomObject(235, "Ameer");
            CustomObject b = new CustomObject(112, "Sae'ed");

            print($"a Object name is {a.Name} and ID number is {a.ID}");
            print($"a Object name is {b.Name} and ID number is {b.ID}");

            print($"Is Object a = b {a == b}");

            print($"null == null = {null == null} for the Fisrt Condition in the ovloading operator");

        }

        // Update is called once per frame

    }
}