using System;

// Superclass
class Animal
{
    public string Name;
    public int Age;

    // Constructor
    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Virtual method
    public virtual void MakeSound()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

// Subclass Dog
class Dog : Animal
{
    public Dog(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}

// Subclass Cat
class Cat : Animal
{
    public Cat(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine("Cat meows");
    }
}

// Subclass Bird
class Bird : Animal
{
    public Bird(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine("Bird chirps");
    }
}

class AnimalHierarchy
{
    public static void Main()
    {
        Animal animal1 = new Dog("Maxy", 12);
        Animal animal2 = new Cat("Roxy", 2);
        Animal animal3 = new Bird("Cocky", 2);

        animal1.MakeSound();
        animal2.MakeSound();
        animal3.MakeSound();
    }
}
