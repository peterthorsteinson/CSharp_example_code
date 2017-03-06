// Main

using System;

class Program
{
    static void Main()
    {
        ClassUnderTest cut = new ClassUnderTest();
        int result;
        result = cut.GoodAddIntegers(3, 4);
        Console.WriteLine(result);          // output: 7
        result = cut.BadAddIntegers(3, 4);
        Console.WriteLine(result);          // output: 12
    }
}
