using System;

namespace _01.SmallestΟfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstN = int.Parse(Console.ReadLine());
            int secondN = int.Parse(Console.ReadLine());
            int thirdN = int.Parse(Console.ReadLine());

            Console.WriteLine(SmallestNumber(firstN, secondN, thirdN));
        }

        private static int SmallestNumber(int firstN, int secondN, int thirdN)
        {
            int[] numbers = new [] {firstN, secondN, thirdN};
            Array.Sort(numbers);
            return numbers[0];
        }
    }
}
