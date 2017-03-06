// Stopwatch

using System;
using System.Diagnostics;

class Program
{
    // "brute force" algorithm (iterative approach)
    static int SimpleSumIntegerUpToLimit(int limit)
    {
        int sum = 0;
        for (int count = 1; count <= limit; count++)
        {
            sum += count;
        }
        return sum;
    }

    // "clever" algorithm
    static int CleverSumIntegerUpToLimit(int limit)
    {
        return (limit * (limit + 1)) >> 1;
    }

    static void Main(string[] args)
    {
        int limit;
        int result;
        Stopwatch stopWatch = new Stopwatch();

        limit = 10;
        stopWatch.Start();
        result = SimpleSumIntegerUpToLimit(limit);
        stopWatch.Stop();
        Console.WriteLine("\nSimple algorithm " +
            limit + " is: " + result);
        Console.WriteLine("Ticks: " + stopWatch.ElapsedTicks);
        stopWatch.Reset();
        stopWatch.Start();
        result = CleverSumIntegerUpToLimit(limit);
        stopWatch.Stop();
        Console.WriteLine("\nClever algorithm " +
            limit + " is: " + result);
        Console.WriteLine("Ticks: " + stopWatch.ElapsedTicks);
        stopWatch.Reset();

        limit = 10;
        stopWatch.Start();
        result = SimpleSumIntegerUpToLimit(limit);
        stopWatch.Stop();
        Console.WriteLine("\nSimple algorithm " +
            limit + " is: " + result);
        Console.WriteLine("Ticks: " + stopWatch.ElapsedTicks);
        stopWatch.Reset();
        stopWatch.Start();
        result = CleverSumIntegerUpToLimit(limit);
        stopWatch.Stop();
        Console.WriteLine("\nClever algorithm " +
            limit + " is: " + result);
        Console.WriteLine("Ticks: " + stopWatch.ElapsedTicks);
        stopWatch.Reset();

        limit = 100000;
        stopWatch.Start();
        result = SimpleSumIntegerUpToLimit(limit);
        stopWatch.Stop();
        Console.WriteLine("\nSimple algorithm " +
            limit + " is: " + result);
        Console.WriteLine("Ticks: " + stopWatch.ElapsedTicks);
        stopWatch.Reset();
        stopWatch.Start();
        result = CleverSumIntegerUpToLimit(limit);
        stopWatch.Stop();
        Console.WriteLine("\nClever algorithm " +
            limit + " is: " + result);
        Console.WriteLine("Ticks: " + stopWatch.ElapsedTicks);
        stopWatch.Reset();

        limit = 1000000;   // to big for "clever" algorithm
        stopWatch.Start();
        result = SimpleSumIntegerUpToLimit(limit);
        stopWatch.Stop();
        Console.WriteLine("\nSimple algorithm " +
            limit + " is: " + result);
        Console.WriteLine("Ticks: " + stopWatch.ElapsedTicks);
        stopWatch.Reset();
        stopWatch.Start();
        result = CleverSumIntegerUpToLimit(limit);
        stopWatch.Stop();
        Console.WriteLine("\nClever algorithm " +
            limit + " is: " + result);
        Console.WriteLine("Ticks: " + stopWatch.ElapsedTicks);
        stopWatch.Reset();
    }
}