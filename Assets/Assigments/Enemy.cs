using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    public Enemy(string name, int haelth) : base(name, haelth)
    {


    }
    public void Attack(int value, Character player)
    {
        player.charHealth -= value;
    }

}
