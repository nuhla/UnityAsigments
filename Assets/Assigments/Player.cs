using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    string playerName = "NewPlayer";    int health = 100;    static int playerCount = 0;
    public void InitializePlayer(string name, int initialHealth)
    {
        playerCount++;        playerName = name;        health = initialHealth;
    }
    public void Heal(int amount)
    {
        if (health + amount > 100)        {            health = 100;        }
        else if (health + amount < 0)        {            health = 0;        }
        else        {            health += amount;        }
        Debug.Log("Health is : " + health);
        Debug.Log("From Main method");
    }
    public void Heal(bool fullRestore)
    {
        if (fullRestore)        {            health = 100;        }

        Debug.Log("Health is : " + health);
        Debug.Log("From Overload method");
    }
    public static void ShowPlayerCount()
    {
        Debug.Log("Number of Players is : " + playerCount);
    }

}
