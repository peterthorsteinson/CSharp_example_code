// DataConversionMethods
class Program
{
    static void Main()
    {
        int answerToEverything = 42;
        const double PI = 3.141592;
        bool lateForLunch = true;

        System.Console.WriteLine(answerToEverything.ToString()); // output: 42
        System.Console.WriteLine(PI.ToString());                 // output: 3.141592
        System.Console.WriteLine(lateForLunch.ToString());       // output: true

        System.DateTime dtUTC_OneSmallStepforMan =
            System.Convert.ToDateTime("21 July 2008 02:56:15 AM");
        System.Console.WriteLine(
            dtUTC_OneSmallStepforMan); // output: 7/21/2008 2:56:15 AM

        double bodyTemperatureFahrenheit = double.Parse("98.6");
        System.Console.WriteLine(bodyTemperatureFahrenheit);     // output: 98.6
    }
}