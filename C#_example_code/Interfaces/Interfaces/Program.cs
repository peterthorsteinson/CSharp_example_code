// Interfaces

using System;

interface IMammal  // No implementation
{
    void Breath(); // May not all breath same way
    void Sleep();  // May not all sleep same way
    void Eat();    // May not all eat same way
}

class Zebra : IMammal
{
    public void Breath() { Console.WriteLine("Zebra.Breath"); }
    public void Sleep() { Console.WriteLine("Zebra.Sleep"); }
    public void Eat() { Console.WriteLine("Zebra.Eat"); }
}

class Lion : IMammal
{
    public void Breath() { Console.WriteLine("Lion.Breath"); }
    public void Sleep() { Console.WriteLine("Lion.Sleep"); }
    public void Eat() { Console.WriteLine("Lion.Eat"); }
}

class Bat : IMammal
{
    public void Breath() { Console.WriteLine("Bat.Breath"); }
    public void Sleep() { Console.WriteLine("Bat.Sleep"); }
    public void Eat() { Console.WriteLine("Bat.Eat"); }
}

class Program
{
    static void Main()
    {
        //IMammal mammal = new IMammal(); // Cannot instantiate interface!!!
        //mammal.Breath();
        //mammal.Eat();
        //mammal.Sleep();
        //Console.WriteLine("???\n");

        IMammal[] critters = {
            new Lion(), new Zebra(), new Bat(), new Lion() };

        foreach (IMammal critter in critters) // Polymorphism
        {
            critter.Breath();
            critter.Eat();
            critter.Sleep();
            Console.WriteLine();
        }
    }
}
