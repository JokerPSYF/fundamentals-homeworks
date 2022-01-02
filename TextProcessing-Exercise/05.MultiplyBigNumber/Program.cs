using System;
using System.Text;

namespace _05.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());
            int reminder = 0;
            StringBuilder result = new StringBuilder();
            if (multiplier == 0 || bigNumber == "0")
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                int n = int.Parse(bigNumber[i].ToString());
                int digit = n * multiplier + reminder;
                int product = digit % 10;
                reminder = digit / 10;
                result.Insert(0, product);
            }

            if (reminder > 0)
            {
                result.Insert(0, reminder);
            }

            Console.WriteLine(result);

        }
    }
}
