// PrimesEnumerator

using System;
using System.Collections;

class PrimesEnumerator : IEnumerable, IEnumerator
{
    public PrimesEnumerator(int length)
    {
        this.length = length; // desired number of primes
    }

    public IEnumerator GetEnumerator()
    {
        return this;
    }

    int position = 0;
    int length;

    public bool MoveNext()
    {
        position++;
        return (position <= length);
    }

    public void Reset() { position = 0; }

    public object Current // readonly property
    {
        get
        {
            if (position == 1) return 2;
            if (position == 2) return 3;

            int j;
            int n = 2;
            int i = 5;
            while (n < position)
            {
                int isprime = 1;
                double r = Math.Sqrt(i);
                for (j = 3; j <= r; j += 2)
                    if ((i % j) == 0)
                    {
                        isprime = 0;
                        break;
                    }
                n += isprime;
                i += 2;
            }
            return i;
        }
    }
}

class Program
{
    static void Main()
    {
        PrimesEnumerator primes = new PrimesEnumerator(10);

        foreach (int prime in primes)
        {
            Console.WriteLine(prime);
        }
    }
}
