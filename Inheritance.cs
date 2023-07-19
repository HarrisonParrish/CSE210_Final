using System;

class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic animal sound");
    }
}

class Mammal : Animal
{
    public int NumberOfLegs { get; set; }
    public bool CanSwim { get; set; }

    public Mammal(string name, int age, int numberOfLegs, bool canSwim)
        : base(name, age)
    {
        NumberOfLegs = numberOfLegs;
        CanSwim = canSwim;
    }

    public override void MakeSound()
    {
        Console.WriteLine("Mammal sound: ...");
    }
}

class Bird : Animal
{
    public double WingSpan { get; set; }
    public bool CanFly { get; set; }

    public Bird(string name, int age, double wingSpan, bool canFly)
        : base(name, age)
    {
        WingSpan = wingSpan;
        CanFly = canFly;
    }

    public override void MakeSound()
    {
        Console.WriteLine("Bird sound: Chirp chirp!");
    }
}

class Reptile : Animal
{
    public bool HasScales { get; set; }

    public Reptile(string name, int age, bool hasScales)
        : base(name, age)
    {
        HasScales = hasScales;
    }

    public override void MakeSound()
    {
        Console.WriteLine("Reptile sound: Hiss...");
    }
}

class Program
{
    static void Main()
    {
        Mammal dog = new Mammal("Dog", 5, 4, true);
        Bird eagle = new Bird("Eagle", 3, 2.5, true);
        Reptile snake = new Reptile("Snake", 2, true);

        Animal[] animals = { dog, eagle, snake };

        foreach (Animal animal in animals)
        {
            Console.WriteLine($"Name: {animal.Name}, Age: {animal.Age}");
            animal.MakeSound();
            Console.WriteLine();
        }
    }
}
