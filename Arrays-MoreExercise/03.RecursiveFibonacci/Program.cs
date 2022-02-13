using System;

namespace _03.RecursiveFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int nth = int.Parse(Console.ReadLine());
            Console.WriteLine(Fibonacci(nth));
            Console.WriteLine();
        }

        private static int Fibonacci(int nth)
        {
            int[] fibonacciArr = new int[50];
            fibonacciArr[0] = 1;
            fibonacciArr[1] = 1;
            for (int i = 2; i < 50; i++)
            {
                fibonacciArr[i] = fibonacciArr[i - 1] + fibonacciArr[i - 2];
            }

            return fibonacciArr[nth - 1];
        }
    }
}
