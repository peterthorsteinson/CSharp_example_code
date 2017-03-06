// GenericVsNonGenericCollections

using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        ArrayList stringsArrayList = new ArrayList();
        stringsArrayList.Add("Is");
        stringsArrayList.Add("the");
        stringsArrayList.Add("number");
        //stringsArrayList.Add(13); // Compiles but gives runtime error!
        stringsArrayList.Add("unlucky");
        stringsArrayList.Add("?");
        Console.WriteLine("Using ArrayList");
        foreach (string word in stringsArrayList)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();

        List <string> stringsGenericList = new List<string>();
        stringsGenericList.Add("Is");
        stringsGenericList.Add("the");
        stringsGenericList.Add("number");
        //stringsGenericList.Add(13); // Gives compile error!
        stringsGenericList.Add("unlucky");
        stringsGenericList.Add("?");
        Console.WriteLine("Using List<string>");
        foreach (string word in stringsArrayList)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();
    }
}
