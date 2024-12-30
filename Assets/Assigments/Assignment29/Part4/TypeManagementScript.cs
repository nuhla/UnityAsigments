using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assigment29.Part4
{
    public class TypeManagementScript : MonoBehaviour
    {

        private void Start()
        {

            //Upcasting:
            // ■ Create a Cat object and upcast it(implicitly) to an Animal reference.
            // ■ Call both MakeSound() and Move() on the upcasted reference.
            Cat cat = new Cat();
            Animale animale = cat;
            animale.MakeSound();
            animale.Move();

            //Downcasting:
            // ■ Downcast the Animal reference back to a Cat object using the as
            // keyword.
            // ■ Call both MakeSound() and Move() on the downcasted object.

            Cat cat2 = animale as Cat;

            cat2.MakeSound();
            cat2.Move();

            List<ICanFight> _list = new List<ICanFight> { new Cat(), new Warrior() };

            foreach (ICanFight item in _list)
            {
                item.Attack();
                if (item is Cat) Debug.Log("The object is a Cat.");
                if (item is Warrior) Debug.Log("The object is a Warrior.");
            }


        }
    }


    public class Animale
    {
        public virtual void MakeSound()
        {
            Debug.Log("Animal moves.");
        }

        public void Move()
        {
            Debug.Log("Cat runs quickly.");
        }
    }


    public class Cat : Animale, ICanFight
    {
        public override void MakeSound()
        {
            Debug.Log("Meow!");
        }

        public void Move()
        {
            Debug.Log("Cat runs quickly.");
        }

        public void Attack()
        {
            Debug.Log("Cat attacks with claws!");
        }
    }

    public class Warrior : ICanFight
    {
        public void Attack()
        {
            Debug.Log("Warrior attacks with a sword!");
        }
    }

    public interface ICanFight
    {
        public void Attack();
    }
}
