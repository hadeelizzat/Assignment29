using System.Collections.Generic;
using UnityEngine;
namespace Assignment29
{
    //part4
    public class TypeManagementScript : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Animal cat = new Cat();
            cat.MakeSound();
            cat.Move();
            Cat cat2 = (Cat)cat;
            cat2.MakeSound();
            cat2.Move();
            List<ICanFight> canFights = new List<ICanFight>() { new Cat(), new Warrior() };
            foreach (ICanFight canFight in canFights)
            {
                canFight.Attack();
            }
            foreach (ICanFight canFight in canFights)
            {
                if (canFight is Cat)
                    Debug.Log("The object is a Cat.");
                else
                    Debug.Log("The object is a Warrior.");
            }

        }
    }
    public class Animal
    {
        public virtual void MakeSound()
        {
            Debug.Log("Animal sound");
        }
        public void Move()
        {

            Debug.Log("Animal moves.");
        }
    }
    public class Cat : Animal, ICanFight
    {
        public void Attack()
        {
            Debug.Log("Cat attacks with claws!");
        }

        public override void MakeSound()
        {
            Debug.Log("Meow!");

        }
        public new void Move()
        {
            Debug.Log("Cat runs quickly.");
        }

    }
    public interface ICanFight
    {
        public void Attack();
    }
    public class Warrior : ICanFight
    {
        public void Attack()
        {
            Debug.Log("Warrior attacks with a sword!");
        }
    }

}