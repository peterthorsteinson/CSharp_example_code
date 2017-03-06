// LINQ_QueryArray

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Five Lettered Names:");
        string[] names = {
            "John", "Sally",
            "Bob", "Sebastian",
            "Frank", "Norma",
            "William", "Jane" };

        Console.WriteLine("\nLINQ query operator syntax using keywords");
        var query1 = from name in names
                     where name.Length == 5
                     orderby name
                     select name.ToUpper();
        foreach (string name in query1)
            Console.WriteLine(name);

        Console.WriteLine("\nLINQ extension method syntax using lambdas");
        var query2 = names
            .Where(s => s.Length == 5)
            .OrderBy(s => s)
            .Select(s => s.ToUpper());
        foreach (string name in query1)
            Console.WriteLine(name);

        Console.WriteLine("\nEven Numbers:");
        int[] numbers = new int[10];
        Random random = new Random();
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 101);
        }
        Console.WriteLine("\nLINQ query operator syntax using keywords");
        var query3 = from number in numbers
                          where number % 2 == 0
                          select number;
        foreach (int number in query3)
            Console.WriteLine(number);

        Console.WriteLine("\nLINQ extension method syntax using lambdas");
        var query4 = numbers
            .Where(n => n % 2 == 0)
            .Select(n => n);
        foreach (int number in query4)
            Console.WriteLine(number);
    }
}

