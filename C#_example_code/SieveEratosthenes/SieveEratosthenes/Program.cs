// SieveEratosthenes

class Program
{
    static void Main()
    {
        // Sieve of Eratosthenes
        // https://en.wikipedia.org/wiki/Sieve_of_Eratosthenes#Algorithm_complexity
        // O(n log log n)

        // create empty list
        System.Collections.Generic.List<int> nonPrimes =
            new System.Collections.Generic.List<int>();

        // define upper limit for primalty testing
        int max = 100;

        // iterate over numbers x from 2 to square root of max
        for (int x = 2; x * x <= max; x++)
        {
            // mark off all multiples of current number x as non-prime
            for (int y = x * 2; y < max; y += x)
            {
                if (!nonPrimes.Contains(y)) // avoid duplicates
                {
                    nonPrimes.Add(y);
                }
            }
        }

        // display the primes less than max
        for (int x = 2; x < max; x++) // 2 is smallest prime
        {
            if (!nonPrimes.Contains(x)) // only display if prime
            {
                System.Console.WriteLine(x);
            }
        }
    }
}

