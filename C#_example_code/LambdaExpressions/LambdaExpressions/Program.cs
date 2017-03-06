// LambdaExpressions

using System;

delegate double MyFunctionDelegate(double x, double y);

class Program
{
    static double Add(double x, double y)
    {
        return x + y;
    }
    static double Subtract(double x, double y)
    {
        return x - y;
    }
    static double Multiply(double x, double y)
    {
        return x * y;
    }
    static double Divide(double x, double y)
    {
        return x / y;
    }
    static void DoCallback(Func<double, double, double> cb, int x, int y)
    {
        Console.WriteLine(cb(x, y));
    }

    static void Main()
    {
        MyFunctionDelegate mfd1 = new MyFunctionDelegate(Add);
        Console.WriteLine(mfd1(5, 2));                   // output: 7
        MyFunctionDelegate mfd2 = Subtract;              // short-cut syntax
        Console.WriteLine(mfd2(5, 2));                   // output: 3
        Func<double, double, double> mfd3 = Multiply;    // generic delegate
        Console.WriteLine(mfd3(5, 2));                   // output: 10
        Func<double, double, double> mfd4 = (x, y)=>x/y; // lambda expression
        Console.WriteLine(mfd4(5, 2));                   // output: 2.5
        DoCallback((x, y) => Math.Pow(x, y), 5, 2);      // output: 25
        DoCallback((x, y) => Math.Sqrt(x*x+y*y), 5, 2);  // output: 5.3851648071345
    }
}
