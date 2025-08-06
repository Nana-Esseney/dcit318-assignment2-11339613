/*using System;

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


namespace AbstractClassesDemo
{
    // Abstract class Shape
    public abstract class Shape
    {
        public abstract double GetArea();
        
        // Optional: Add a concrete method that can be used by derived classes
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"This shape has an area of: {GetArea():F2} square units");
        }
    }

    // Derived class Circle
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Circle with radius {radius}:");
            Console.WriteLine($"Area = π × {radius}² = {GetArea():F2} square units");
        }
    }

    // Derived class Rectangle
    public class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override double GetArea()
        {
            return length * width;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Rectangle with length {length} and width {width}:");
            Console.WriteLine($"Area = {length} × {width} = {GetArea():F2} square units");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Abstract Classes and Methods Demo ===");
            Console.WriteLine();

            // Create instances of Circle and Rectangle
            Circle myCircle = new Circle(5.0);
            Rectangle myRectangle = new Rectangle(4.0, 6.0);

            // Display their areas
            Console.WriteLine("Shape Area Calculations:");
            Console.WriteLine();

            myCircle.DisplayInfo();
            Console.WriteLine();

            myRectangle.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine("=== Direct Area Method Calls ===");
            Console.WriteLine($"Circle area: {myCircle.GetArea():F2}");
            Console.WriteLine($"Rectangle area: {myRectangle.GetArea():F2}");

            Console.WriteLine();
            Console.WriteLine("=== Demonstrating Polymorphism with Abstract Classes ===");
            
            // Using abstract class references (polymorphism)
            Shape[] shapes = { new Circle(3.0), new Rectangle(2.5, 4.0), new Circle(7.2) };
            
            for (int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine($"\nShape {i + 1}:");
                shapes[i].DisplayInfo();
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}*/

using System;

namespace InterfacesDemo
{
    // Define interface IMovable
    public interface IMovable
    {
        void Move();
    }

    // Class Car that implements IMovable
    public class Car : IMovable
    {
        private string brand;
        private string model;

        public Car(string brand, string model)
        {
            this.brand = brand;
            this.model = model;
        }

        public void Move()
        {
            Console.WriteLine("Car is moving");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{brand} {model} car:");
        }
    }

    // Class Bicycle that implements IMovable
    public class Bicycle : IMovable
    {
        private string type;
        private int gears;

        public Bicycle(string type, int gears)
        {
            this.type = type;
            this.gears = gears;
        }

        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{type} bicycle with {gears} gears:");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Interfaces Demo ===");
            Console.WriteLine();

            // Create instances of Car and Bicycle
            Car myCar = new Car("Toyota", "Camry");
            Bicycle myBicycle = new Bicycle("Mountain", 21);

            // Call Move() method on each instance
            Console.WriteLine("Direct method calls:");
            myCar.DisplayInfo();
            myCar.Move();

            Console.WriteLine();

            myBicycle.DisplayInfo();
            myBicycle.Move();

            Console.WriteLine();
            Console.WriteLine("=== Demonstrating Interface Polymorphism ===");

            // Using interface references (polymorphism)
            IMovable[] movableObjects = { new Car("Honda", "Civic"), new Bicycle("Road", 18), new Car("Ford", "Focus") };

            for (int i = 0; i < movableObjects.Length; i++)
            {
                Console.Write($"Movable object {i + 1}: ");
                movableObjects[i].Move();
            }

            Console.WriteLine();
            Console.WriteLine("=== Interface Reference Examples ===");

            // Demonstrate interface references
            IMovable vehicle1 = new Car("BMW", "X5");
            IMovable vehicle2 = new Bicycle("Hybrid", 7);

            Console.WriteLine("Using interface references:");
            Console.Write("Vehicle 1: ");
            vehicle1.Move();

            Console.Write("Vehicle 2: ");
            vehicle2.Move();

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}