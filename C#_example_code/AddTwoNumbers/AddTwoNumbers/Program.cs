// AddTwoNumbers

using System;

class Program
{
    // method implementation
    static int AddTwoNumbers(int x, int y)
    {
        return x + y;
    }

    // program entry point method
    static void Main()
    {
        int x = 10;
        int y = 20;
        int result = AddTwoNumbers(x, y); // method invocation

        Console.WriteLine(result); // output: 30
    }
}

