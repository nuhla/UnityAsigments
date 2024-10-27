using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class AssigmentEight : MonoBehaviour
{
    // Start is called before the first frame update

    // 1. Write a C# script that generates random numbers (from 1 to 20) using a while loop.
    // 2. Print each number.If the number is 5, use continue to skip printing it.
    // 3. If the number is 15, use break to exit the loop.
    // 4. Submit the script to your GitHub repo and provide the link.
    // 5. No need for screenshots this time.
    void Start()
    {
        int counter = 0;
        int randNumber = 0;
        while (counter < 20)
        {
            randNumber = Random.Range(1, 21);
            counter++;
            if (randNumber == 5) continue;

            Debug.Log(randNumber);
            if (randNumber == 15) break;


        }


        // Exercise 2: Funny Sentence Generator:
        // 1.Write a C# script that uses an array of these words:
        // Cat, Dog, Car, Pizza, Hat, Fish, Tree, Monkey, Ball, Bird.
        // 2.Use a while loop to build a funny sentence with 7 words randomly chosen from the
        // array.
        // 3.Print the sentence to the console.
        // 4.Submit the script to your GitHub repo and provide the link.
        // 5.No need for screenshots this time. 
        string[] words = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };
        string sentence = "";
        int wordCouts = 0;
        string randomWord = "";


        while (wordCouts < 7)
        {
            randNumber = Random.Range(0, 10);
            randomWord = words[randNumber];
            if (sentence.Contains(randomWord)) continue;
            sentence += " " + randomWord;
            ++wordCouts;

        }

        Debug.Log(sentence);

    }


}
