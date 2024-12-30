using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
namespace Assigment29.Part3
{
    public static class Utilities
    {
        // Start is called before the first frame update
        public static int Add(params int[] numbers)
        {
            int sumation = 0;
            foreach (int number in numbers)
            {
                sumation += number;
            }
            return sumation;
        }

        public static string RepeatString(this string str, int times)
        {
            string result = "";

            for (int i = 0; i < times; i++)
            {
                result += str;
            }
            return result;
        }
    }
}