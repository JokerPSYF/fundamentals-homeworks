using System;

namespace Methods_Lab
{
    class Program
    {
        static void IsNegative(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            IsNegative(num);
        }
    }
}
