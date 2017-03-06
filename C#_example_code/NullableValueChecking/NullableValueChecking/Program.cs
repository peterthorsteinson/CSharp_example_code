// NullableValueChecking

class Program
{
    static void Main()
    {
        decimal? bonus = null;

        if (bonus.HasValue)
        {
            decimal b = bonus.Value;
            System.Console.WriteLine("bonus: " + b); // not executed
        }
        else
        {
            System.Console.WriteLine("bonus: null"); // executed
        }

        bonus = 1000.00m;
        if (bonus.HasValue)
        {
            decimal b = bonus.Value;
            System.Console.WriteLine("bonus: " + b); // executed
        }
        else
        {
            System.Console.WriteLine("bonus: null"); // not executed
        }

    }
}
