// MethodOverloading

using System;
using System.Collections.Generic;

class MyClass
{
    public int GetLength(string text)
    {
        return text.Length; // number of characters
    }
    public int GetLength(int integer)
    {
        return integer.ToString().Length; // number of digits
    }
    public int GetLength(int [] integerArray)
    {
        return integerArray.Length; // number of array elements
    }
    public int GetLength(List<int> integerList)
    {
        return integerList.Count; // number of list items
    }
}

class Program
{
    static void Main()
    {
        MyClass mc = new MyClass();

        string text = "Hello";                            // 5 characters
        Console.WriteLine(mc.GetLength(text));            // output: 5

        int integer = 1234;                               // 4 digits
        Console.WriteLine(mc.GetLength(integer));         // output: 4

        int[] integerArray = new int[] { 1, 2, 3 };       // 3 elements
        Console.WriteLine(mc.GetLength(integerArray));    // output: 3

        List<int> integerList = new List<int>() { 1, 2 }; // 2 items
        Console.WriteLine(mc.GetLength(integerList));     // output: 2
    }
}
