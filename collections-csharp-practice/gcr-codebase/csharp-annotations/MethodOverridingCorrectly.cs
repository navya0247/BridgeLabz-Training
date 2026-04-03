using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.collections.annotations
{
        class Animal
        {
            public virtual void MakeSound()
            {
                Console.WriteLine("Animal makes a sound");
            }
        }

        class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Dog barks");
            }
        }

       internal class MethodOverridingCorrectly
        {
            public static void Main(string[] args)
            {
                Animal a = new Dog();
                a.MakeSound();
            }
        }
    }

