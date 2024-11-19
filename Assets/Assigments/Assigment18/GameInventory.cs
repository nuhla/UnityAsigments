using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assigment18
{
    public class GameInventory : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Inventory test = new Inventory();
            test.AddItem("Healing Potion");
            test.AddItem("Strength Potion");


            Inventory elixirs = new Inventory();
            elixirs.AddItem("Elixir");
            elixirs.AddItem("Dark Elixir");



            Inventory result = test + elixirs;
            result.ShowItems();
        }


    }
}