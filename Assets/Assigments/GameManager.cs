using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player mario = new Player();
        Player patot = new Player();

        mario.InitializePlayer("Mario", 100);
        patot.InitializePlayer("Pattot", 100);


        mario.Heal(-50);
        mario.Heal(20);
        mario.Heal(true);


        patot.Heal(100);
        patot.Heal(-30);
        patot.Heal(false);


        Player.ShowPlayerCount();
    }


}
