using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment35.part2
{
    public delegate void MathOperation(int number);
    public class MulticastDelegateExample : MonoBehaviour
    {
        MathOperation operation;
        // Start is called before the first frame update
        void Start()
        {

            operation += DoubleNumber;
            operation += SquareNumber;
            operation += CubeNumber;
            operation.Invoke(5);

        }

        void DoubleNumber(int number)
        {
            Debug.Log(number * 2);
        }

        void SquareNumber(int number)
        {
            Debug.Log(number * number);
        }

        void CubeNumber(int number)
        {
            Debug.Log(number * number * number);
        }
    }
}