// NestedIfElseConstructs 

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter some keyboard characters: ");

        while (true)
        {
            char ch = (char)Console.Read();
            if (Char.IsLetter(ch))
            {
                if (Char.IsUpper(ch))
                {
                    Console.WriteLine("Uppercase character: " + ch);
                }
                else
                {
                    Console.WriteLine("Lowercase character: " + ch);
                }
            }
        }
    }
}

