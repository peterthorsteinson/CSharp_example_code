// ClassUnderTest

public class ClassUnderTest
{
    public int GoodAddIntegers(int x, int y)
    {
        return x + y; // good
    }
    public int BadAddIntegers(int x, int y)
    {
        return x * y; // bad
    }
}
