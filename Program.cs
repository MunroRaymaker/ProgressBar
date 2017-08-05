using System;

namespace Progress
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length > 0)
            {
                Console.WriteLine($"Hello {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello World!");
            }

            Console.WriteLine("Performing time consuming task...");

            using(var progress = new ProgressBar())
            {
                for(int i = 0; i < 100; i++)
                {
                    progress.Report((double) i / 100);
                    System.Threading.Thread.Sleep(200);
                }
            }

            Console.WriteLine("Task is done!");

            Console.WriteLine("Fibonacci numbers 1-15:");

            for(int i = 0; i < 15; i++)            
            {
                Console.WriteLine($"{i+1}: {FibonacciNumber(i)}");
            }
        }

        static int FibonacciNumber(int n)
        {
            int a = 0;
            int b = 1;
            int tmp;

            for(int i = 0; i < n; i++)
            {
                tmp = a;
                a = b; 
                b += tmp; 
            }

            return a;
        }
    }
}
