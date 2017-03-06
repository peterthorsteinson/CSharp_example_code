// FlyweightPattern

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        FlyweightShapeFactory fsf = new FlyweightShapeFactory();

        IShape shape;

        // Get three Square objects
        shape = fsf.GetShape("Square");
        shape.Display();
        shape = fsf.GetShape("Square");
        shape.Display();
        shape = fsf.GetShape("Square");
        shape.Display();

        // Get three Circle objects
        shape = fsf.GetShape("Circle");
        shape.Display();
        shape = fsf.GetShape("Circle");
        shape.Display();
        shape = fsf.GetShape("Circle");
        shape.Display();

        // Actually created only two objects
        int noc = fsf.NumberObjectsCreated;
        Console.WriteLine($"\nNumber objects actually created: {noc}");
    }
}

interface IShape
{
    void Display();
}

class Square : IShape
{
    public void Display()
    {
        Console.WriteLine("Square");
    }
}

class Circle : IShape
{
    public void Display()
    {
        Console.WriteLine("Circle");
    }
}

class FlyweightShapeFactory
{
    Dictionary<string, IShape> shapes = new Dictionary<string, IShape>();

    public int NumberObjectsCreated
    {
        get { return shapes.Count; }
    }

    public IShape GetShape(string shapeName)
    {
        IShape shape = null;
        if (!shapes.ContainsKey(shapeName))  // Create new object
        {
            switch (shapeName)
            {
                case "Square":
                    shape = new Square();
                    shapes.Add("Square", shape);
                    break;
                case "Circle":
                    shape = new Circle();
                    shapes.Add("Circle", shape);
                    break;
                default:
                    throw new Exception("Ooops: invalid shapeName");
            }
        }
        else                               // Use existing object 
        {
            shape = shapes[shapeName];
        }
        return shape;
    }
}
