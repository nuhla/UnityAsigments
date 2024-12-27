using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assigment29.Part1
{
    public class PartOne : MonoBehaviour
    {

        // Start is called before the first frame update
        void Start()
        {

            var str = "";
            var number = 3;
            var isOdd = false;

            isOdd = number % 2 == 0 ? !isOdd : isOdd;
            str = isOdd ? $" The Number {number} is Odd" : $"The Number {number} Is Even";

            Debug.Log(str);
            Debug.Log(System.DateTime.Now.Date);
            Debug.Log(System.DateTime.Now.TimeOfDay);
            Debug.Log(System.DateTime.Now.Day);

        }

        // Update is called once per frame

    }
}