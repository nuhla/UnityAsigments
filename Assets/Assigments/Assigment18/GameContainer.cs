using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Assigment18
{



    public class GameContainer<T>
    {
        private T val;

        public void SetItem(T item)
        {
            this.val = item;
        }

        public T GetItem()
        {
            return this.val;
        }
    }
}