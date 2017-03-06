// EuclideanAlgorithm

class Program
{
    static int EuclideanAlgorithm(int a, int b)
    {
        while (a != 0 && b != 0)
        {
            if (a > b)
                a %= b;
            else
                b %= a;
        }

        if (a == 0)
            return b;
        else
            return a;
    }

    static void Main()
    {
        System.Console.WriteLine(
            EuclideanAlgorithm(252, 105)); // output: 21
    }
}

