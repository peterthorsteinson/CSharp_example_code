// TwiceSumOfDigits

using System;
using System.Linq;

// Only one positive integer that is twice the sum of its digits
// Lets find that number!

class Program
{
    static int[] GetDigitsArray(int integer)
    {
        return integer.ToString().Select(t => int.Parse(t.ToString())).ToArray();
    }

    static int GetArraySum(int[] digits)
    {
        int sum = 0;
        foreach (int i in digits)
        {
            sum += i;
        }
        return sum;
    }

    static void Main()
    {
        int i = 1;

        while (true)
        {
            int[] digitsArray = GetDigitsArray(i);
            int sum = GetArraySum(digitsArray);

            if (sum * 2 == i)
            {
                Console.WriteLine(i);
                break;
            }

            i++;
        }
    }
}
