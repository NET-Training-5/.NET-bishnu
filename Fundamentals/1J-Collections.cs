using System;
using System.Collections.Generic;

class Collection
{
    byte[] ages = { 2, 3, 4, 5, 6, 7, 8, 12, 34 };
    
    void LearnList()
    {
        List<byte> numbers = new List<byte>();
        numbers.Add(23);
        numbers.Add(237);
        numbers.Add(123);
        numbers.Add(23);
        numbers.Remove(237);

        List<string> names = new List<string>() { "Bishnu", "Ram", "Hari" };

        foreach (var item in names)
        {
            Console.WriteLine(item);
        }
    }

    void LearnDictionary()
    {
        Dictionary<string, long> countryPopulation = new();
        countryPopulation.Add("Nepal", 9387092482048);
        countryPopulation.Add("India", 938709241111111);
        countryPopulation.Add("China", 938705676472324);
        countryPopulation.Add("USA", 870923453425);
        countryPopulation.Add("Canada", 248204857775);

        countryPopulation.Remove("China");
    }
}
