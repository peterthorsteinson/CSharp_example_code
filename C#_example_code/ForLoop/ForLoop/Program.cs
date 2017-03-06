// ForLoop

using System;

class Program
{
    static bool isPrime(int number)
    {
        if (number == 1) return false;
        if (number == 2) return true;
        int sqrtInt = (int)Math.Ceiling(Math.Sqrt(number));
        for (int i = 2; i <= sqrtInt; ++i)
        {
            if (number % i == 0) return false; // not prime
        }
        return true; // if we get here it must be prime
    }

    static void Main()
    {
        for (int candidate = 2; candidate <= 20; candidate++)
        {
            Console.Write(candidate);
            Console.WriteLine(": " + isPrime(candidate));
        }
    }
}

