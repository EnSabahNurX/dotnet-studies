using System;

namespace DigitalInnovationOne
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            int times = 5;
            for (int i = 0; i < times; i++)
            {
                // Console.WriteLine($"Welcome to the .NET course {i}");
                Console.WriteLine($"Welcome to the .NET course {i}");
            }
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
            Console.Write($"{Environment.NewLine}Press any key to exit...\n");
            Console.ReadKey(true);
        }
    }
}
