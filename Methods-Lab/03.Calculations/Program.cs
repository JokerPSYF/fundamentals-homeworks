using System;

namespace _03.Calculations
{
    class Program
    {
        static void add(int a , int b)
        {
            Console.WriteLine(a + b);
        }
        static void multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        static void subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        static void divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }
        static void Main(string[] args)
        {
            string calculation = Console.ReadLine();
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            switch (calculation)
            {
                case "add":
                    add(firstNum , secondNum );
                    break;
                case "multiply":
                    multiply(firstNum, secondNum);
                    break;
                case "subtract":
                    subtract(firstNum, secondNum);
                    break;
                case "divide":
                    divide(firstNum, secondNum);
                    break;
            }
        }
    }
}
