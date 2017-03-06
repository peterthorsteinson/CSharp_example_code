// AddTwoNumbersNonStatic

using System;

class Program
{
    // method implementation
    int AddTwoNumbers(int x, int y) // non-static method
    {
        return x + y;
    }

    // program entry point method
    static void Main()
    {
        int x = 10;
        int y = 20;
        Program prog = new Program(); // need instance for non-static
        int result = prog.AddTwoNumbers(x, y); // call non-static method

        Console.WriteLine(result); // output: 30
    }
}
