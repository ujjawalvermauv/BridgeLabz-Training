using System;

// Interface for birds that can fly
interface IFlyable
{
    void Fly();
}

// Interface for birds that can swim
interface ISwimmable
{
    void Swim();
}

// Base class Bird containing common attributes
class Bird
{
    public string Name;

    // Constructor to initialize bird name
    public Bird(string name)
    {
        Name = name;
    }

    // Method to display bird name
    public void Display()
    {
        Console.WriteLine("Bird Name: " + Name);
    }
}

// Eagle can fly
class Eagle : Bird, IFlyable
{
    public Eagle(string name) : base(name) { }

    public void Fly()
    {
        Console.WriteLine(Name + " flies at a very high altitude.");
    }
}

// Sparrow can fly
class Sparrow : Bird, IFlyable
{
    public Sparrow(string name) : base(name) { }

    public void Fly()
    {
        Console.WriteLine(Name + " flies short distances.");
    }
}

// Duck can swim
class Duck : Bird, ISwimmable
{
    public Duck(string name) : base(name) { }

    public void Swim()
    {
        Console.WriteLine(Name + " swims in ponds and lakes.");
    }
}

// Penguin can swim
class Penguin : Bird, ISwimmable
{
    public Penguin(string name) : base(name) { }

    public void Swim()
    {
        Console.WriteLine(Name + " swims very fast in cold water.");
    }
}

// Seagull can both fly and swim
class Seagull : Bird, IFlyable, ISwimmable
{
    public Seagull(string name) : base(name) { }

    public void Fly()
    {
        Console.WriteLine(Name + " flies over the sea.");
    }

    public void Swim()
    {
        Console.WriteLine(Name + " swims near the shore.");
    }
}
class BirdSanctuary
{
    static void Main()
    {
        // Array of Bird references (Polymorphism)
        Bird[] birds = new Bird[]
        {
            new Eagle("Eagle"),
            new Sparrow("Sparrow"),
            new Duck("Duck"),
            new Penguin("Penguin"),
            new Seagull("Seagull")
        };

        // Iterate through each bird
        foreach (Bird bird in birds)
        {
            bird.Display();
            // Check if bird can fly
            if (bird is IFlyable)
            {
                ((IFlyable)bird).Fly();
            }
            // Check if bird can swim
            if (bird is ISwimmable)
            {
                ((ISwimmable)bird).Swim();
            }

            Console.WriteLine("");
        }
    }
}
