using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assigment29.Part3
{
    public class TestUtil : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

            Debug.Log($"Utilities.Add for [1,2,3,4,5,6,7,8,9] = {Utilities.Add(1, 2, 3, 4, 5, 6, 7, 8, 9)}");

            Debug.Log($"RepeatString HELLO 3 TIMES ={"HELLO".RepeatString(3)}");

        }

        // Update is called once per frame

    }
}