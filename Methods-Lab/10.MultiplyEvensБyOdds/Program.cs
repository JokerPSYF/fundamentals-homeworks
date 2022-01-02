using System;

namespace _10.MultiplyEvensБyOdds
{
    class Program
    {
        static int GetMultipleOfEvenAndOdds(int even, int odd)
        {
            int result = even * odd;
            return result;

        }

        private static int GetSumOfEvenDigits(int num)
        {
            int evenSum = 0;
            while (num > 0)
            {
                int n = num % 10;
                if (n % 2 == 0)
                {
                    evenSum += n;
                }
               num/= 10;
            }

            int evenResult = evenSum;
            return evenResult;

        }
        private static int GetSumOfOddDigits(int num)
        {
            int oddSum = 0;
            while (num > 0)
            {
                int n = num % 10;
                if (n % 2 != 0)
                {
                    oddSum += n;
                }
                num /= 10;
            }

            int oddResult= oddSum;
            return oddResult;
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int num = Math.Abs(number);
         
            Console.WriteLine(GetMultipleOfEvenAndOdds(GetSumOfEvenDigits(num), GetSumOfOddDigits(num)));
        }
    }
}
