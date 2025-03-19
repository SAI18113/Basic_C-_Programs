using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound.");
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }
    }

    // Derived class (Dog)
    public class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog(string name, string breed) : base(name) // Call the base class constructor
        {
            Breed = breed;
        }

        public override void MakeSound() // Override the base class method
        {
            Console.WriteLine($"{Name} (a {Breed}) barks: Woof!");
        }

        public void Fetch()
        {
            Console.WriteLine($"{Name} is fetching a ball.");
        }
    }

    // Derived class (Cat)
    public class Cat : Animal
    {
        public Cat(string name) : base(name)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} meows: Meow!");
        }

        public void Climb()
        {
            Console.WriteLine($"{Name} is climbing a tree.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal genericAnimal = new Animal("Generic Animal");
            Dog myDog = new Dog("Buddy", "Golden Retriever");
            Cat myCat = new Cat("Whiskers");

            genericAnimal.MakeSound(); // Animal makes a sound.
            myDog.MakeSound();       // Buddy (a Golden Retriever) barks: Woof!
            myCat.MakeSound();       // Whiskers meows: Meow!

            genericAnimal.Eat(); // Generic Animal is eating.
            myDog.Eat();         // Buddy is eating.
            myCat.Eat();         // Whiskers is eating.

            myDog.Fetch();       // Buddy is fetching a ball.
            myCat.Climb();       // Whiskers is climbing a tree.

            //Polymorphism example.
            Animal animalDog = new Dog("Spot", "Labrador");
            Animal animalCat = new Cat("Mittens");

            animalDog.MakeSound(); // Spot (a Labrador) barks: Woof!
            animalCat.MakeSound(); // Mittens meows: Meow! 
        }
    }
}
