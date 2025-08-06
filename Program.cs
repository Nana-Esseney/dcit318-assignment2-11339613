using System;

namespace InheritanceDemo
{
    // Base class Animal
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    // Derived class Dog
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    // Derived class Cat
    public class Cat : Animal
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
            Console.WriteLine("=== Inheritance and Method Overriding Demo ===");
            Console.WriteLine();

            // Create instances of Animal, Dog, and Cat
            Animal genericAnimal = new Animal();
            Dog myDog = new Dog();
            Cat myCat = new Cat();

            // Call MakeSound() method on each instance
            Console.WriteLine("Animal sounds:");
            Console.Write("Generic Animal: ");
            genericAnimal.MakeSound();

            Console.Write("Dog: ");
            myDog.MakeSound();

            Console.Write("Cat: ");
            myCat.MakeSound();

            Console.WriteLine();
            Console.WriteLine("=== Demonstrating Polymorphism ===");
            
            // Demonstrating polymorphism - using base class reference
            Animal[] animals = { new Animal(), new Dog(), new Cat() };
            
            for (int i = 0; i < animals.Length; i++)
            {
                Console.Write($"Animal {i + 1}: ");
                animals[i].MakeSound();
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
