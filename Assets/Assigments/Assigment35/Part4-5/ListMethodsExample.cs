using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment35.part4and5
{


}
public class ListMethodsExample : MonoBehaviour
{

    List<int> numbers2 = new List<int> { 3, 1, 4, 1, 5, 9, 2, 6 };
    // Start is called before the first frame update
    void Start()
    {
        List<int> filteredNumbers = numbers2.FindAll((number) => number % 2 == 0);
        Debug.Log(string.Join(", ", filteredNumbers));

    }



}

