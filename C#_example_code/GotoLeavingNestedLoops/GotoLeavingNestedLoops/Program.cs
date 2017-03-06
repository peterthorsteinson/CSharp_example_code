// GotoLeavingNestedLoops

using System;

public class Program
{
    public static void Main()
    {
        int max = 5;
        int[,] array = new int[max, max];
        for (int i = 0; i < max; i++)
        {
            for (int j = 0; j < max; j++)
            {
                array[i, j] = i * j;

            }
        }

        int match = 12;
        for (int i = 0; i < max; i++)
        {
            for (int j = 0; j < max; j++)
            {
                Console.WriteLine(i + " * " + j + " = " + array[i, j]);
                if (array[i, j] == match)
                {
                    Console.WriteLine("Match found, leaving nested loops");
                    goto end_of_loop;
                }
            }
        }

    end_of_loop:
        Console.WriteLine("Done");
    }
}
