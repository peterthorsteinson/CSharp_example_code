// TheOutKeyword

using System;

namespace TheOutKeyword
{
    class Program
    {
        static int AddNumbers(int x, int y)
        {
            return x + y;
        }

        static void MultiplyNumbers(int x, int y, out int? result)
        {
            result = x * y;
        }

        static void Main(string[] args)
        {
            int regularInt = 0;
            regularInt = AddNumbers(3, 4);
            Console.WriteLine(regularInt);  // output: 4

            int? nullableInt = null;
            MultiplyNumbers(3, 4, out nullableInt);
            Console.WriteLine(nullableInt); // output: 7

        }
    }
}
