using System;

namespace _08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondtNum = double.Parse(Console.ReadLine());
            double firstFactoriel = MakeFactoriel(firstNum);
            double secondFactoriel = MakeFactoriel(secondtNum);
            double divide = firstFactoriel / secondFactoriel;
            Console.WriteLine($"{divide:f2}");
        }

        private static double MakeFactoriel(double Num)
        {
            double sum = 1;
            for (double i = Num; i >= 1; i--)
            {
                sum *= i;
            }

            return (double)sum;
        }
    }
}
