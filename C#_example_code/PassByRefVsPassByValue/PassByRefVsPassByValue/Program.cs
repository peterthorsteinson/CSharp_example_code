// PassByRefVsPassByValue

using System;

class Program
{
    static void MethodTakingValTypeParameter(int x)
    {
        x++; // only changes local copy in this method
    }

    static void MethodTakingRefTypeParameter(ref int x)
    {
        x++; // changes original object in calling method
    }

    static void Main()
    {
        int a = 10;
        MethodTakingValTypeParameter(a); // pass by value
        Console.WriteLine(a); // output: 10

        int b = 10;
        MethodTakingRefTypeParameter(ref b); // pass by reference
        Console.WriteLine(b); // output: 11
    }
}
