// OverloadingVsDefaultParameters

using System;

class Customer1 // uses constructor overloading
{
    public string CustomerName { get; set; }

    public Customer1()
    {
        CustomerName = "Our Valued Customer";
    }

    public Customer1(string customerName)
    {
        CustomerName = customerName;
    }
}

class Customer2 // uses parameter defaulting
{
    public string CustomerName { get; set; }

    public Customer2(string customerName = "Our Valued Customer")
    {
        CustomerName = customerName;
    }
}

class Program
{
    static void Main()
    {
        // using constructor overloading
        Customer1 c1 = new Customer1();
        Console.WriteLine(c1.CustomerName); // output: Our Valued Customer
        Customer1 c2 = new Customer1("Benny Goodman");
        Console.WriteLine(c2.CustomerName); // output: Benny Goodman

        // using default parameters
        Customer1 c3 = new Customer1();
        Console.WriteLine(c3.CustomerName); // output: Our Valued Customer
        Customer1 c4 = new Customer1("Billie Holiday");
        Console.WriteLine(c4.CustomerName); // output: Billie Holiday
    }
}
