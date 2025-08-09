using System;

namespace Inheritance
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new();
            Dog dog = new();
            Cat cat = new();

            animal.MakeSound();
            dog.MakeSound();
            cat.MakeSound();

            Console.ReadLine();
        }
    }
}