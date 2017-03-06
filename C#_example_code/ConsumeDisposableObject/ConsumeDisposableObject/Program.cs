// ConsumeDisposableObject

public class Program
{
    public static void Main()
    {
        string[] jabberwocky = {
            "The time has come the Walrus said",
            "To talk of many things",
            "Of shoes and ships and sealing-wax",
            "Of cabbages and kings",
            "And why the sea is boiling hot",
            "And whether pigs have wings"
        };

        string path = System.IO.Directory.GetCurrentDirectory() + "\\myfile.txt";

        using (System.IO.StreamWriter sw = new System.IO.StreamWriter(path))
        { // StreamWriter is created here!!!
            foreach (string line in jabberwocky)
                sw.WriteLine(line);
        } // StreamWriter is disposed here!!!

        using (System.IO.StreamReader sr = new System.IO.StreamReader(path))
        { // StreamReader is created here!!!
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
            }
        } // StreamReader is disposed here!!!
    }
}