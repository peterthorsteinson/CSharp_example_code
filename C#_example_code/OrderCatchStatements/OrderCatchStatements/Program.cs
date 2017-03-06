// OrderCatchStatements

using System;

class Program
{
    static void Main()
    {
        int x = 0;
        while (true)
        {
            try
            {
                checked { x += 1; } // can throw OverflowException
                if (x == 13)
                    throw new SuperstitionException();
            }
            catch (SuperstitionException se)  // specific catch earlier
            {
                Console.WriteLine(se.Message);
            }
            catch (Exception e)               // general catch later
            {
                Console.WriteLine(e.Message); // OverflowException
                break;
            }
        }
    }
}

class SuperstitionException : Exception
{
}

