using System;

namespace _04.PrintingTriangle
{
    class Program
    {
        static void printTriangle(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }
            for (int i = number - 1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            printTriangle(n);
        }
    }
}
