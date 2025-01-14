using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assigment35.part3
{
    public class BuiltInDelegatesExample : MonoBehaviour
    {
        Action<string> logMessage;
        Func<int, int> square;

        Predicate<int> isEven;

        // Start is called before the first frame update
        void Start()
        {
            logMessage = (string mess) => Debug.Log(mess);
            logMessage("Hello from Action delegate!");

            square = (int num) => 5 * 5;
            Debug.Log($"Square: {square(5)}");

            isEven = (num) => num % 2 == 0 ? true : false;
            Debug.Log($"Is 4 even? {isEven(4)}");

        }


    }
}
