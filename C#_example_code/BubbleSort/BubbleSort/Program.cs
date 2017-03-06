// BubbleSort

class Program
{
    static void Main()
    {
        // Array to be sorted
        int [] numbers = { 45, 72, 38, 62, 33, 87, 99, 11, 31, 15 };
        bool flag = true;
        int temp;

        // Sort the array
        for (int i = 1; (i <= (numbers.Length - 1)) && flag; i++)
        {
            flag = false;
            for (int j = 0; j < (numbers.Length - 1); j++)
            {
                if (numbers[j + 1] > numbers[j])
                {
                    temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                    flag = true;
                }
            }
        }

        // Display the sorted array
        foreach (int num in numbers)
        {
            System.Console.WriteLine(num);
        }
    }
}

