using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a generic sound.");
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

    class Program
    {
        static void Main(string[] args)
        {
            Animal genericAnimal = new Animal();
            Dog myDog = new Dog();
            Cat myCat = new Cat();

            genericAnimal.MakeSound(); // Output: Animal makes a generic sound.
            myDog.MakeSound();       // Output: Dog barks: Woof!
            myCat.MakeSound();       // Output: Cat meows: Meow!

            // Polymorphism example:
            Animal animalDog = new Dog();
            Animal animalCat = new Cat();

            animalDog.MakeSound(); // Output: Dog barks: Woof!
            animalCat.MakeSound(); // Output: Cat meows: Meow!
        }
    }
}
