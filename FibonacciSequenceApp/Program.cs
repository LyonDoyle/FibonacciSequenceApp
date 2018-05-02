using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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

                //Thread.Sleep(100);
            }

            stopwatch.Stop();

            Console.WriteLine($"elapsed: {stopwatch.ElapsedMilliseconds}ms");

            Console.Read();
        }
    }
}
