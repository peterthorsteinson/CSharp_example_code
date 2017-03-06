// StaticMember

using System;

class MyClass
{
    static public int StaticMember;
}

class Program
{
    static void Main()
    {
        MyClass.StaticMember = 42;
        Console.WriteLine(MyClass.StaticMember); // output: 42
    }
}
