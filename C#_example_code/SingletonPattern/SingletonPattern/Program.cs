// SingletonPattern

using System;

// POTUS means "President of the United States"
public sealed class POTUS
{
    private POTUS() { }
    private static POTUS instance = new POTUS();
    public static POTUS Instance
    {
        get { return instance; }
    }

    public string FirstName = "Donald";
    public string LastName = "Trump";
}

class Program
{
    static void Main()
    {
        string fn = POTUS.Instance.FirstName;
        string ln = POTUS.Instance.LastName;
        Console.WriteLine($"{fn} {ln}"); // output: Donald Trump
    }
}

