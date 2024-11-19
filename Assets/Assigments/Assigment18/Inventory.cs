using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using JetBrains.Annotations;
using UnityEngine;

namespace Assigment18
{
    public class Inventory
    {
        private List<string> itemName = new List<string>();

        public bool AddItem(string item)
        {
            try
            {
                this.itemName.Add(item);
            }
            catch
            {
                return false;
            }

            return true;

        }

        public void ShowItems()
        {
            foreach (string item in this.itemName)
            {
                Debug.Log(item);
            }
        }

        public static Inventory operator +(Inventory Inv1, Inventory Inv2)
        {

            Inventory result = new Inventory();
            // int maxCounter = 0;

            for (int i = 0; i < Inv1.itemName.Count; i++)
            {
                result.AddItem(Inv1.itemName[i]);

            }
            for (int y = 0; y < Inv2.itemName.Count; y++)
            {
                result.AddItem(Inv2.itemName[y]);
            }


            return result;


        }
    }
}
