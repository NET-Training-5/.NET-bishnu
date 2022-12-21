// Parallel Programming - Multithreading, Task-based (TPL - Task Parallel Library)
// Asynchronous Programming - async/await

using System;
using System.Threading;
using System.Threading.Tasks;

class ParallelAndAsync
{
    public void WriteParallelCode()
    {
        // Sequential loop
        Console.WriteLine("Sequential:");
        for (byte i = 1; i <= 10; i++)
        {
            DoTask(i);
        }

        // Prallel loop
        Console.WriteLine("Parallel:");
        Parallel.For(1, 11, i => DoTask(i));
    }

    void DoTask(int counter)
    {
        Thread.Sleep(1000);
        Console.WriteLine($"Done with task {counter}");
    }

    // CW - Create collection of 20 large enough integrals, write an implementation to find
    // out if those numbers are prime or not.

    // 1 - Create array of 20 long numbers
    // 2 - Write a method to check if a number is prime or not
    // 3 - Loop through all numbers on step 1 to find primeness of all

    public void PrimalityTest()
    {
        long[] numbers = {311341,34234232,345345345,345345345,21313,78786868,24323224,3453535,5575646723424,
                        2343245235, 32452345,35435345468769,89544646,133213,5363533,2312313,87575754};
        
        Console.WriteLine("Sequential:");
        foreach (var item in numbers)
        {
            var p = isPrime(item) ? "Prime" : "Composite";
            Console.WriteLine($"{item} is {p}");
        }

        Console.WriteLine("Parallel:");
        Parallel.ForEach(numbers, (item) =>
        {
            var p = isPrime(item) ? "Prime" : "Composite";
            Console.WriteLine($"{item} is {p}");
        });
    }

    bool isPrime(long n)
    {
        Thread.Sleep(500);
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }

        return true;
    }


    public async Task<string> WriteAsyncCode()
    {
        // Non-blocking code
        await DownLoad();

        return "Success";
    }

    async Task DownLoad()
    {
        await Task.Delay(1000);
    }
}
