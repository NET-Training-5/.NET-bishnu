class EntryPoint
{
    public static void Main()
    {
        // Console.Write("Enter your name:");
        // var x = Console.ReadLine();
        // Console.WriteLine(x + " Wow, Nice name");
        // Console.WriteLine("Nepal is beautiful country");

        // Selection sel1 = new(); 
        // sel1.LearnSelectionStatements();

        Loop l = new();
        Loop l1 = new();

        l.LearnLoops();
        l1.LearnLoops();

        Method m = new();
        m.Print();
        m.Print("Nepal");
        var mess = m.GetMessage();
        var sum = m.Add(23.5, 56.8);

        var a = m.FindAverage(2345, 4324, 3535);
        var b = m.FindAverage(2345, 4324, 3535, 79238427);
        var c = m.FindAverage(3, 4, 5, 5, 2345, 4324, 3535, 79238427);


        // Type casting
        // byte a = 234;
        // int b = a;          // Implicit casting
        // byte c = (byte)b;   // Explicit casting

        var age = 23;
        var name = "Ram";
        var m1 = name + " is " + age + " years old";
        var mi = $"{name} is {age} years old."; // String interpolation

        Console.WriteLine(mi);





    }
}
