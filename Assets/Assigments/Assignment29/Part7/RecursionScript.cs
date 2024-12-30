using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assigment29.part3
{
    public class RecursionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Debug.Log(FibonacciRecursive(10));
        Debug.Log(FibonacciIterative(30));
    }

    int FibonacciRecursive(int n)
    {
        return (n < 2) ? n : FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }

    int FibonacciIterative(int x)
    {
        if (x == 0) return 0;

        int prev = 0;
        int next = 1;
        for (int i = 1; i < x; i++)
        {
            int sum = prev + next;
            prev = next;
            next = sum;
        }
        return next;
    }
    // Update is called once per frame

}
}