// AddTwoNumbersSeperateClasses

using System;

class MyMath
{
    // instance method implementation
    public int AddTwoNumbers(int x, int y) // non-static method
    {
        return x + y;
    }

    // class method implementation
    static public int MultiplyTwoNumbers(int x, int y) // static method
    {
        return x * y;
    }
}

class Program
{
    static void Main()
    {
        int x = 10;
        int y = 20;

        MyMath mm = new MyMath();   // need instance for non-static
        int sum = mm.AddTwoNumbers(x, y); // call non-static method
        Console.WriteLine(sum);     // output: 30

        int product = MyMath.MultiplyTwoNumbers(x, y); // call non-static method
        Console.WriteLine(product); // output: 200

    }
}
