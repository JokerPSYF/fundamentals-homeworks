using System;

namespace _08.MathPower
{
    class Program
    {
        static double PowTheNumber(double n, double pow)
        {
            return Math.Pow(n, pow);
        }
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double powNumber = double.Parse(Console.ReadLine());
            Console.WriteLine(PowTheNumber(firstNumber, powNumber));
        }
    }
}
