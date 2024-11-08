using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : Character
{

    public Player2(string name, int haelth)
    {
        this.charHealth = haelth;
        this.charName = name;
    }
    // Start is called before the first frame update
    public void Heal(int value)
    {
        this.charHealth += value;
    }
}
