using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Player mario = new Player();
        // Player patot = new Player();

        // mario.InitializePlayer("Mario", 100);
        // patot.InitializePlayer("Pattot", 100);


        // mario.Heal(-50);
        // mario.Heal(20);
        // mario.Heal(true);


        // patot.Heal(100);
        // patot.Heal(-30);
        // patot.Heal(false);


        // Player.ShowPlayerCount();
        Debug.Log("------------------------------------------------\n-----------------Object Init--------------------\n------------------------------------------------\n");


        Player2 player = new Player2("As3ad", 50);
        Enemy enamy = new Enemy("sa3eed", 30);
        Debug.Log("Player Name : " + player.charName);
        Debug.Log("Player Health : " + player.charHealth);
        Debug.Log("Eamy Name : " + enamy.charName);
        Debug.Log("Enamy Health : " + enamy.charHealth);


        Debug.Log("------------------------------------------------ \n------------------Heal Test---------------------\n------------------------------------------------\n");

        player.Heal(20);
        Debug.Log("Test Heal Player : " + player.charHealth);


        Debug.Log("------------------------------------------------\n-----------------Attack Test--------------------\n------------------------------------------------");
        enamy.Attack(50, player);

        Debug.Log("(after attack) Enamy Health : " + enamy.charHealth);
        Debug.Log("(after attack) Enamy name : " + enamy.charName);

        Debug.Log("(after attack) Player name : " + player.charName);
        Debug.Log("(after attack) Player Health : " + player.charHealth);


    }


}
