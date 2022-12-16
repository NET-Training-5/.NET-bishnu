// LINQ - Language Integrated Query

using System;
using System.Collections.Generic;
using System.Linq;

class LINQ
{
    int[] numbers = { 3, 4, 6, 8, 1, 3, 4, 51, 45, 67, 12, 34, 35 };
    
    public void LearnToQuery()
    {
        PrintValues(numbers, "Input Array: ");

        // List all even numbers from "numbers" array
        // Declarative Way
        var evenNumbers = numbers.Where(x => x % 2 == 0);        
        PrintValues(evenNumbers, "Even Numbers: ");

        // List all odd numbers which are divisible by 3
        var oddNumbers = numbers.Where(x => x % 2 != 0 && x % 3 == 0);
        PrintValues(oddNumbers, "Odd Numbers divisible by 3: ");

        // List multiples of 5 and 7 from "numbers"
        var multipleOf5And7 = numbers.Where(x => x % 5 == 0 && x % 7 == 0);        
        PrintValues(multipleOf5And7, "Multiple of 5 and 7: ");

        // List all items less than 100 with trailing 0, from "numbers"
        var numbersWithTrailing0 = numbers.Where(x => x < 100 && x.ToString().EndsWith("0"));

        // Projections
        // Print squares of all items in numbers array
        var squares = numbers.Select(x => x * x);
        PrintValues(squares, "Squares: ");

        // Print square root of all items less than 50
        var sqRoots = numbers.Where(x => x < 50).Select(x => Math.Round(Math.Sqrt(x), 2));
        
        // Expression syntax
        var sqRoots2 =  from x in numbers
                        where x < 50
                        select Math.Round(Math.Sqrt(x), 2);
        
        
        PrintValues(sqRoots, "Square roots (< 50): ");

        // Sort numbers
        var numbersSorted = numbers.Order();
    }

    void PrintValues<U>(IEnumerable<U> items, string label)
    {
        Console.Write($"\n{label}");
        foreach(var item in items)
            Console.Write(item + " ");       
    }
}
