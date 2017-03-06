// OperatorOverloading

using System;

public struct ComplexInt
{
    public int real; // real part
    public int imag; // imaginary part

    public ComplexInt(int real, int imag)
    {
        this.real = real;
        this.imag = imag;
    }

    public static ComplexInt operator +(ComplexInt lhs, ComplexInt rhs)
    {
        return new ComplexInt(lhs.real + rhs.real, lhs.imag + rhs.imag);
    }

    public override string ToString()
    {
        return (String.Format($"({real} + {imag}i)"));
    }
}
class Program
{
    static void Main()
    {
        ComplexInt c1 = new ComplexInt(4, 5);
        ComplexInt c2 = new ComplexInt(7, 9);
        ComplexInt c3 = c1 + c2; // invoke overloaded + operator
        Console.WriteLine($"{c1} + {c2} -> {c3}");
    }
}
