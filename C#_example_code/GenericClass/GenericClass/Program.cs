// GenericClass

using System;

class NonGenericCompareClass
{
    static public bool Compare(string x, string y)
    {
        if (x.Equals(y))
            return true;
        else
            return false;
    }

    static public bool Compare(int x, int y)
    {
        if (x.Equals(y))
            return true;
        else
            return false;
    }
}

class GenericCompareClass<T>
{
    static public bool Compare(T x, T y)
    {
        if (x.Equals(y))
            return true;
        else
            return false;
    }
}

class Program
{
    static void Main()
    {
        bool isEqual;

        isEqual = NonGenericCompareClass.Compare(3, 4);
        Console.WriteLine(isEqual); // output: False
        isEqual = NonGenericCompareClass.Compare(5, 5);
        Console.WriteLine(isEqual); // output: True
        isEqual = NonGenericCompareClass.Compare("Up", "Down");
        Console.WriteLine(isEqual); // output: False
        isEqual = NonGenericCompareClass.Compare("Quark", "Quark");
        Console.WriteLine(isEqual); // output: True

        isEqual = GenericCompareClass<int>.Compare(3, 4);
        Console.WriteLine(isEqual); // output: False
        isEqual = GenericCompareClass<int>.Compare(5, 5);
        Console.WriteLine(isEqual); // output: True
        isEqual = GenericCompareClass<string>.Compare("Up", "Down");
        Console.WriteLine(isEqual); // output: False
        isEqual = GenericCompareClass<string>.Compare("Quark", "Quark");
        Console.WriteLine(isEqual); // output: True
    }
}
