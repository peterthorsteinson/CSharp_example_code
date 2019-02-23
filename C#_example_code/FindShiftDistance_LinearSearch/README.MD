```csharp
// Given a right-shifted sorted array [8, 10, 15, 3, 5, 7],
// write a function to find the shift distance
// (i.e. find shift in rotated sorted array)

using System;

class FindShiftDistance_LinearSearch
{
    static int findShift(int[] arr, int n)
    {
        // find index of minimum element 
        int min = arr[0], min_index = -1;
        for (int i = 0; i < n; i++)
        {
            if (min > arr[i])
            {
                min = arr[i];
                min_index = i;
            }
        }
        return min_index;
    }

    public static void Main()
    {
        int[] array = { 8, 10, 15, 3, 5, 7 };
        Console.WriteLine(findShift(array, array.Length));
    }
}
```
