using System;
using System.Numerics;

namespace _10.TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int topNum = int.Parse(Console.ReadLine());
            FindTopNumber(topNum);
        }

        private static void FindTopNumber(int topNum)
        {
            for (int i = 17; i <= topNum; i++)
            {
                bool isOddDigit = false;
                int digitSum = 0;
                int j = i;
                while (j > 0)
                {
                    int digit = j % 10;
                    if (digit % 2 != 0) isOddDigit = true;
                    digitSum += digit;
                    j /= 10;
                }

                if (digitSum % 8 == 0 && isOddDigit)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
