// TheParamsKeyword

using System;

namespace TheParamsKeyword
{
    class Program
    {
        public static void TestdParamsKeyword(params int [] paramList)
        {
            for (int i = 0; i < paramList.Length; i++)
            {
                Console.Write(paramList[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            TestdParamsKeyword(1, 2);           // output: 1 2
            TestdParamsKeyword(1, 2, 3, 4);     // output: 1 2 3 4
            int[] intArray = { 10, 20, 30 };
            TestdParamsKeyword(intArray);       // output: 10 20 30
        }
    }
}
