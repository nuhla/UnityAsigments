using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Character
{
    string name = "";
    int haelth = 100;

    public string charName
    {
        get { return name; }
        set { name = value; }

    }

    public int charHealth
    {
        get { return haelth; }
        set
        {
            if (value >= 100) haelth = 100;
            else if (value <= 0) haelth = 0;
            else { haelth = value; }

        }
    }

    public Character(string charcterName, int helthValue)
    {
        this.name = charcterName;
        this.charHealth = helthValue;
    }
    public Character() : this("", 100)
    {
    }
}
