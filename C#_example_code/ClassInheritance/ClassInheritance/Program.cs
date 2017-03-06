// ClassInheritance

using System;

public class BankAccount
{
    protected decimal _Balance;

    public BankAccount(decimal balance)
    {
        _Balance = balance;
        Console.WriteLine(
            "Initial BankAccount -> balance: " + _Balance);
    }

    public decimal GetBalance()
    {
        return _Balance;
    }

    public void Deposit(decimal amount)
    {
        _Balance += amount;
        Console.WriteLine(
            "After Deposit -> balance: " + _Balance);
    }

    public void Withdraw(decimal amount)
    {
        _Balance -= amount;
        Console.WriteLine(
            "After Withdraw -> balance: " + _Balance);
    }
}

public class SavingsAccount : BankAccount
{
    private static decimal _InterestRate;

    public SavingsAccount(decimal balance, decimal interestRate)
        : base(balance)
    {
        _InterestRate = interestRate;
        Console.WriteLine(
            "Initial SavingsAccount -> interest rate: " +
            _InterestRate);
    }

    public void AccrueInterest()
    {
        _Balance *= (1 + _InterestRate / 12);
        Console.WriteLine("After AccrueInterest -> balance: " +
            GetBalance());
    }
}

public class CheckingAccount : BankAccount
{
    private static decimal _MgmtFee;

    public CheckingAccount(decimal balance, decimal mgmtFee)
        : base(balance)
    {
        _MgmtFee = mgmtFee;
        Console.WriteLine(
            "Initial CheckingAccount -> mgmtFee: " +
            _MgmtFee);
    }

    public void ChargeMgmtFee()
    {
        _Balance -= _MgmtFee;
        Console.WriteLine("After ChargeMgmtFee -> balance: " +
            GetBalance());
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Test SavingsAccount");
        SavingsAccount sa = new SavingsAccount(100, 0.05m);
        sa.Deposit(50.0m);
        sa.AccrueInterest();
        sa.Withdraw(50.0m);
        Console.WriteLine("---");

        Console.WriteLine("Test CheckingAccount");
        CheckingAccount ca = new CheckingAccount(100, 10.0m);
        ca.Deposit(50.0m);
        ca.ChargeMgmtFee();
        ca.Withdraw(50.0m);
        Console.WriteLine("---");
    }
}
