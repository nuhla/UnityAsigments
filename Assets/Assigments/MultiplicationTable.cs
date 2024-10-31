using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{

    int Multiplay(int firstNumber, int secondNumber)
    {

        return firstNumber * secondNumber;
    }
    // Start is called before the first frame update
    void Start()
    {
        int numberToMultiply = 5;
        int result = 0;
        string printedResult = "";

        printedResult += "***********************************\n";
        printedResult += "*Multiplication table for number 5*\n";
        for (int i = 1; i <= 10; i++)
        {
            result = Multiplay(numberToMultiply, i);
            printedResult += i + "*" + numberToMultiply + "          =          " + result + "    \n";

        }
        printedResult += "***********************************\n";

        Debug.Log(printedResult);

    }

    // Update is called once per frame

}
