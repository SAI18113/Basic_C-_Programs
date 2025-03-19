using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    // Base class (Animal)
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound.");
        }
    }

    // Derived class (Dog)
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks: Woof!");
        }
    }

    // Derived class (Cat)
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat meows: Meow!");
        }
    }

    // Derived class (Cow)
    public class Cow : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cow moos: Moo!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Polymorphism in action:
            Animal[] animals = new Animal[4];
            animals[0] = new Animal();
            animals[1] = new Dog();
            animals[2] = new Cat();
            animals[3] = new Cow();

            foreach (Animal animal in animals)
            {
                animal.MakeSound(); // Calls the appropriate MakeSound() method based on the object's actual type.
            }

            //Another example, passing animal objects to a method.
            Console.WriteLine("\nSound example using Method Polymorphism:");
            MakeAnimalSound(new Animal());
            MakeAnimalSound(new Dog());
            MakeAnimalSound(new Cat());
            MakeAnimalSound(new Cow());
        }

        public static void MakeAnimalSound(Animal animal)
        {
            animal.MakeSound();
        }
    }
}
