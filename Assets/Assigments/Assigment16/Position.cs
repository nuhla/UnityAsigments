using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{
    //1. Create a namespace, Assignment18, to organize all classes and the struct in
    //this assignment.
    public struct Position
    {
        //1. Inside the namespace, create a struct named Position.
        public float x;
        public float y;
        //2. Position should have two public fields (float X, float Y, and float Z) and a
        //constructor to initialize these fields.
        public Position(int xValue, int yValue)
        {
            this.x = xValue;
            this.y = yValue;
        }

        //3. Create a method printPosition to Debug.Log the x,y,z values.
        public void printPosition()
        {
            Debug.Log("Position is x : " + x + " y : " + y);
        }
    }

}