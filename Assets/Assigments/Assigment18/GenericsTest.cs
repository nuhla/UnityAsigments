using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assigment18
{
    public class GenericsTest : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            GameContainer<string> game = new GameContainer<string>();
            game.SetItem("Health Potion.");

            Debug.Log("Stored item : " + game.GetItem());

            string log = GameUtils.DescribeItem<string>(game.GetItem());

            Debug.Log(log);

        }


    }
}