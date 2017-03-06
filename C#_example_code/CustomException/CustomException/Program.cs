// CustomException

using System;

class Program
{
    static void Main()
    {
        BankAccount ba = new BankAccount();
        try
        {
            ba.Deposit(100.00m);
            ba.DisplayBalance();
            ba.Withdraw(100.00m); // no error
            ba.DisplayBalance();

            ba.Deposit(1000.00m);
            ba.DisplayBalance();
            ba.Withdraw(1100.00m); // error!
            ba.DisplayBalance();
        }
        catch (OverdrawnException od)
        {
            Console.WriteLine("Error message: " + od.Message);
            Console.WriteLine("Overdraft amount: " + od.Overdraft);
            Console.WriteLine("Available balance: " + ba.Balance);
        }
    }
}

class BankAccount
{
    public decimal Balance = 0.0m;
    public void Deposit(decimal amount)
    {
        Balance += amount;
    }
    public void Withdraw(decimal amount)
    {
        if (amount > Balance)
            throw new OverdrawnException(Balance - amount);
        Balance -= amount;
    }
    public void DisplayBalance()
    {
        Console.WriteLine(Balance);
    }
}

// Attempted withdrawl in excess of available funds
class OverdrawnException :  Exception
{
    public decimal Overdraft = 0.0m;
    public OverdrawnException(decimal amount) : 
        base("Overdraft Error!")
    {
        Overdraft = amount;
    }
}
