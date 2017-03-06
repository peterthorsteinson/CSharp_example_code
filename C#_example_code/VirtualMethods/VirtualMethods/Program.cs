// VirtualMethods

using System;

class Mammal
{
    public void Breath()        // All breath the same way
    {
        Console.WriteLine("Mammal.Breath");
    }

    virtual public void Sleep() // Only Bat sleeps weird
    {
        Console.WriteLine("Mammal.Sleep");
    }

    virtual public void Eat()   // All eat different ways
    {
        Console.WriteLine("Mammal.Eat");
    }
}

class Zebra : Mammal
{
    override public void Eat()  // Zebra eats grass
    {
        Console.WriteLine("Zebra.Eat");
    }
}

class Lion : Mammal
{
    override public void Eat()  // Lion eats meat
    {
        Console.WriteLine("Lion.Eat");
    }
}

class Bat : Mammal
{
    override public void Eat()  // Bat eats insects while flying at night
    {
        Console.WriteLine("Bat.Eat");
    }

    override public void Sleep() // Bat sleeps upside-down/nocturnal
    {
        Console.WriteLine("Bat.Sleep");
    }
}

class Program
{
    static void Main()
    {
        Mammal mammal = new Mammal(); // Does this make sense ???
        mammal.Breath();
        mammal.Eat();
        mammal.Sleep();
        Console.WriteLine("???\n");

        Mammal[] critters = {
            new Lion(), new Zebra(), new Bat(), new Lion() };

        foreach (Mammal critter in critters) // Polymorphism
        {
            critter.Breath();
            critter.Eat();
            critter.Sleep();
            Console.WriteLine();
        }
    }
}
