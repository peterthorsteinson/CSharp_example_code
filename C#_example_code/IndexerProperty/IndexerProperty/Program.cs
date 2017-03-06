// IndexerProperty

using System;

class MyClass
{
    public int this[int index] // indexer property
    {
        get
        {
            return index * 2;
        }
    }
}

class Program
{
    static void Main()
    {
        MyClass mc = new MyClass();
        Console.WriteLine(mc[5]); // output: 10
    }
}
