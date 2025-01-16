using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment35.Part8
{
    public class NewBehaviourScript : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            DerivedClassExample derivedClassExample = new DerivedClassExample();
            derivedClassExample.PerformAction();
            derivedClassExample.PrintInfo();

        }


    }
}