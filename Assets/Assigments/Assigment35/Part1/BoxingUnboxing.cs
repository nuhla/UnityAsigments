using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment35.part1
{
    public class BoxingUnboxing : MonoBehaviour
    {
        int health = 100;
        // Start is called before the first frame update
        void Start()
        {
            Debug.Log(health);
            object obj = health;
            Debug.Log(obj);
            int modifiedValue = (int)obj + 5;
            Debug.Log(modifiedValue);
        }


    }
}
