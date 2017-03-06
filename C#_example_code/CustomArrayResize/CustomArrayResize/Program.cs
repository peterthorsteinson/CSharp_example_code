// CustomArrayResize

using System;

class Program
{
    // resize an array with any number of dimensions
    static Array ResizeArray(Array array, int[] newSizes)
    {
        if (array.Rank != newSizes.Length)
            throw new ArgumentException(
                "Array to be resized must have same number of " +
                "dimensions as length of newSizes parameter", "newSizes");
        var newArray = Array.CreateInstance(array.GetType().GetElementType(), newSizes);
        int length = array.Length <= newArray.Length ? array.Length : newArray.Length;
        Array.ConstrainedCopy(array, 0, newArray, 0, length);
        return newArray;
    }

    static void Display2DArray(int[,] array)
    {
        for (int i = 0; i <= array.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= array.GetUpperBound(1); j++)
            {
                Console.Write($"[{i},{j}]: {array[i, j],3}\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

    }

    static void Main()
    {
        // Make a 5x3 2-D array
        Console.WriteLine("Make a 5x3 2-D array");
        int[,] myArray = new int[5, 3];
        for (int i = 0; i <= myArray.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= myArray.GetUpperBound(1); j++)
            {
                myArray[i, j] = i * (myArray.GetUpperBound(1) + 1) + (j + 1);
            }
        }
        Display2DArray(myArray);

        // Increase 2-D array length from 5 to 8 in first dimension
        Console.WriteLine("Increase 2-D array length from 5 to 8 in first dimension");
        myArray = (int[,])ResizeArray(myArray, new int[] { 8, 3 });
        Display2DArray(myArray);

        // Decrease 2-D array length from 8 to 2 in first dimension
        Console.WriteLine("Decrease 2-D array length from 8 to 2 in first dimension");
        myArray = (int[,])ResizeArray(myArray, new int[] { 2, 3 });
        Display2DArray(myArray);

        // Increase 2-D array length from 3 to 6 in second dimension
        Console.WriteLine("Increase 2-D array length from 3 to 6 in second dimension");
        myArray = (int[,])ResizeArray(myArray, new int[] { 8, 6 });
        Display2DArray(myArray);
    }
}
