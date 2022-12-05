class EntryPoint
{
    public static void Main()
    {
        // Console.Write("Enter your name:");
        // string x = Console.ReadLine();
        // Console.WriteLine(x + " Wow, Nice name");
        // Console.WriteLine("Nepal is beautiful country");

        Selection sel1 = new(); 
        sel1.LearnSelectionStatements();

        //Loops, iterations
        // for, while, do-while, foreach

        for (int counter = 60; counter > 50; counter--)
        {
            Console.WriteLine("Nepal");
        }

        for (byte num = 1; num <= 100; num++)
        {
            Console.Write(num + " ");
        }

        int n = 1;
        while(n <= 100)
        {
            Console.Write(n + " ");
            n++;
        }

        // While - use case
        string key = "y";
        while(key == "y")
        {
            Console.WriteLine("Nepal");

            key = Console.ReadLine();
        }

        // CW - Print even numbers less than 500
        // CW - Print odd numbers less than 500
        // CW - Print all numbers less than 500 which are multiple of 3 and 5
        Console.WriteLine("Odd numbers:");
        for (int num = 0; num < 500; num++)
        {
            if (num % 2 != 0)
            {
                Console.Write(num + " ");
            }
        }

        Console.WriteLine("Multiples of 3 and 5:");
        for (int num = 0; num < 500; num++)
        {
            if (num % 3 == 0 && num % 5 == 0 )
            {
                Console.Write(num + " ");
            }
        }


    }
}
