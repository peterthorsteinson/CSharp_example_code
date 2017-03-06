// EuclideanAlgorithmRecursive

class Program
{
    static int EuclideanAlgorithmRecursive(int a, int b)
    {
        if (a == 0)
            return b;
        if (b == 0)
            return a;

        if (a > b)
            return EuclideanAlgorithmRecursive(a % b, b);
        else
            return EuclideanAlgorithmRecursive(a, b % a);
    }

    static void Main(string[] args)
    {
        System.Console.WriteLine(
            EuclideanAlgorithmRecursive(252, 105)); // output: 21
    }
}
