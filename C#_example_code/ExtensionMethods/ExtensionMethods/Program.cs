// ExtensionMethods

using System;
using System.Linq;

public static class MyExtensions
{
    public static int WordCount(this String text)
    {
        return text.Split(new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries).Length;
    }
    public static int Square(this int n)
    {
        return n*n;
    }
    public static int SumOfValues(this int[] integers)
    {
        int sum = 0;
        foreach (int n in integers)
        {
            sum += n;
        }
        return sum;
    }
    public static int SumOfSquares(this int[] integers)
    {
        int sum = 0;
        foreach (int n in integers)
        {
            sum += n*n;
        }
        return sum;
    }
    public static void ProcessValuesWithCallback(
        this int[] integers, Func<int, int> callback)
    {
        for (int i=0; i< integers.Count(); i++)
        {
            integers[i] = callback(integers[i]);
        }
    }
}

class Program
{
    static void Main()
    {
        string text = "Veni Vidi Vici";
        int wordCount = text.WordCount();
        Console.WriteLine(wordCount);  // output: 3

        Console.WriteLine(5.Square()); // output: 25

        int[] integers = new int[] { 1, 2, 3, 4, 5 };
        Console.WriteLine(integers.SumOfValues());  // output: 15
        Console.WriteLine(integers.SumOfSquares()); // output: 55

        // System.Linq.OrderBy (LINQ extension method)
        int[] ints = { 13, 49, 17, 41, 24, 33 };
        var result = ints.OrderBy(n => n);
        foreach (var i in result)
        {
            Console.Write(i + " "); // output: 13 17 24 33 41 49
        }
        Console.WriteLine();

        ints.ProcessValuesWithCallback(n => n*2);
        foreach (var i in result)
        {
            Console.Write(i + " "); // output: 26 34 48 66 82 98
        }
        Console.WriteLine();
    }
}
