using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

namespace Assigment27
{


}
public class assigment27 : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

        int num1 = 10;
        int num2 = 20;
        int num3;
        // ○ Create a method that takes an integer parameter by value and attempts to modify
        // it(e.g., add 10 to it).
        // ○ In Start(), call this method using your first integer variable and then log the
        // value of that variable after the method call to show that it has not changed
        // outside the method. 

        addNumbers(num1);
        Debug.Log($" Value of number befor calling is 10 now is  : {num1} - Call By Value");


        //Call by Reference Demonstration:
        // ○ Create a method that takes an integer parameter by reference using the ref
        // keyword and modifies it(e.g., add 10 to it).
        // ○ In Start(), call this method using ref with your second integer variable and
        // then log the value of that variable after the method call to show that it has
        // changed outside the method.
        addNumbersByRefrence(ref num2);
        Debug.Log($" Value of number befor calling is 20 now is : {num2} - Call By Refrence");


        // Using the out Keyword:
        // ○ Create a method that takes an integer parameter by using the out keyword and
        // assigns it a new value inside the method.
        // ○ In Start(), call this method and then log the variable after the call to
        // demonstrate that even though it wasn’t initialized before the call, it now holds the
        // assigned value.
        addNumbersByOutRefrence(out num3);
        Debug.Log($" Value of number befor calling is None now is : {num3} - Call By Out Refrence");



    }

    // Update is called once per frame
    public void addNumbers(int num)
    {
        num += 30;
    }


    public void addNumbersByRefrence(ref int num)
    {
        num += 30;
    }

    public void addNumbersByOutRefrence(out int num)
    {
        num = 30;
    }
}
