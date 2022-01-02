using System;

namespace _05.AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int sum = SumFirst2(firstNum, secondNum);
            int finalSum = SubstractWithOtherOne(sum, thirdNum);
            Console.WriteLine(finalSum);
        }

        private static int SubstractWithOtherOne(int sum, int thirdNum)
        {
            return sum - thirdNum;
        }

        private static int SumFirst2(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }
    }
}
