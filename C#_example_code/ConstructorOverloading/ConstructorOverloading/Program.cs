// ConstructorOverloading

using System;

class Rectangle
{
    public int Width;
    public int Height;
    bool IsSquare;

    public Rectangle()
    {
        Width = 1;
        Height = 1;
        IsSquare = true;
    }

    public Rectangle(int size)
    {
        Width = size;
        Height = size;
        IsSquare = true;
    }

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
        IsSquare = width== height?true:false;
    }

    public override string ToString()
    {
        string stringSquareOrRect = IsSquare ? "square" : "rectangle";
        return $"{Width}x{Height} {stringSquareOrRect}";
    }
}

class Program
{
    static void Main()
    {
        Rectangle rect;

        rect = new Rectangle();
        Console.WriteLine(rect.ToString()); // output: 1x1 square

        rect = new Rectangle(10);
        Console.WriteLine(rect.ToString()); // output: 10x10 square

        rect = new Rectangle(20, 20);
        Console.WriteLine(rect.ToString()); // output: 20x20 square

        rect = new Rectangle(30, 40);
        Console.WriteLine(rect.ToString()); // output: 30x40 rectangle
    }
}

