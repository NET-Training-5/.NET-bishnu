// LINQ - Language Integrated Query

using System.Collections.Generic;
using System.Linq;

class LINQ
{
    int[] numbers = { 3, 4, 6, 8, 1, 3, 4, 51, 45, 67, 12, 34 };

    void LearnToQuery()
    {
        // List all even numbers from "numbers" array
        
        // Declarative
        var evenNumbers = numbers.Where(x => x % 2 == 0);
        
        // List all odd numbers which are divisible by 3
        var oddNumbers = numbers.Where(x => x % 2 != 0 && x % 3 == 0);

        // List multiples of 5 and 7 from "numbers"
        // List all items less than 100 and ends with 0, from "numbers"
    }
}