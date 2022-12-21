using PreBasic;
using System;
using Inheritance.Example;
class EntryPoint
{
    public static void Main()
    {
        // Console.Write("Enter your name:");
        // var x = Console.ReadLine();
        // Console.WriteLine(x + " Wow, Nice name");
        // Console.WriteLine("Nepal is beautiful country");

        // Variable v = new();
        // Selection sel1 = new(); 
        // sel1.LearnSelectionStatements();

        // Loop l = new();
        // Loop l1 = new();

        // l.LearnLoops();
        // l1.LearnLoops();

        // Method m = new();
        // m.Print();
        // m.Print("Nepal");
        // var mess = m.GetMessage();
        // var sum = m.Add(23.5, 56.8);

        // var a = m.FindAverage(2345, 4324, 3535);
        // var b = m.FindAverage(2345, 4324, 3535, 79238427);
        // var c = m.FindAverage(3, 4, 5, 5, 2345, 4324, 3535, 79238427);


        // Type casting
        // byte a = 234;
        // int b = a;          // Implicit casting
        // byte c = (byte)b;   // Explicit casting

        // var age = 23;
        // var name = "Ram";
        // var m1 = name + " is " + age + " years old";
        // var mi = $"{name} is {age} years old."; // String interpolation

        // Console.WriteLine(mi);

        // var (s, p) = m.GetSumAndProduct(34.5f, 67.2f);
        
        // var (minimum, maximum) = m.FindMinMax(2, 5, -5, 8, 9, 10, 34);
        // Console.WriteLine($"Min:{minimum} Max:{maximum}");

        // Person person1 = new();
        // person1.fullName = "Ram Basnet";
        // person1.dob = new DateTime(1980, 12, 12);
        // person1.address = "Kathmandu";
        // person1.gender = 'M';
        // person1.weight = 78.7f;
        // person1.height = 70.4f;

        // var z = person1.FindAge();
        // var y = person1.FindBMI();
        // Console.WriteLine($"{person1.fullName} is {z:N3} years old and his BMI is {y}");

        // Vehicle car1 = new();
        // Vehicle truck1 = new();
        // car1.Brand = "K";
        // car1.Model = "Nexon EV";
        // car1.PrintDetails();
        // truck1.PrintDetails();

        // FiFa worldcup2018 = new FiFa();
        // worldcup2018.host = "Russia";        
        // worldcup2018.year = new DateTime(2018, 2, 3);        
        // worldcup2018.winner = "France";        
        // worldcup2018.teams = "France, Germany, Brazil";        

        // FiFa worldcup2022 = new("Qatar");
        // FiFa worldcup2002 = 
        //     new("Qatar", new DateTime(2002, 1, 1), 
        //     "Nepal", "France, Germany");


        //var g = FiFa.Groups;
        
        // IShape shape = new Reactangle(43.5f, 12.7f);        
        // var ar = shape.GetArea();
        // var pr = shape.GetPerimeter();

        // shape = new Square(2.3f);
        // var sa = shape.GetArea();
        // var sp = shape.GetPerimeter();

        // shape = new Circle(3.4f);
        // var ca = shape.GetArea();
        // var cp = shape.GetPerimeter();

        // Generic g = new();
        // g.PrintDetails<string>("sfsaf");
        // g.PrintDetails<bool>(false);
        // g.PrintDetails<char>('F');

        // FileIO fi = new();
        // fi.CreateDirectoriesAndFiles();

        // LINQ l = new();
        // l.LearnToQuery();

        ParallelAndAsync parallelAndAsync = new();
        parallelAndAsync.PrimalityTest();
    }
}
