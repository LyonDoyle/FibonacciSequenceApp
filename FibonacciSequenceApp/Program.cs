using System;
using System.Diagnostics;

namespace FibonacciSequenceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int lineNumber = 1;
            long firstNumber = 1;
            long secondNumber = 1;
            long nextNumber = firstNumber + secondNumber;
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            while (nextNumber > 0 && nextNumber < long.MaxValue)
            {
                Console.WriteLine($"{lineNumber}: {nextNumber}");

                lineNumber++;
                firstNumber = secondNumber;
                secondNumber = nextNumber;
                nextNumber = firstNumber + secondNumber;
            }
            stopwatch.Stop();

            Console.WriteLine($"elapsed: {stopwatch.ElapsedMilliseconds}ms\n");
            Console.Write("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
