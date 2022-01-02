using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _09.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string isEnd = Console.ReadLine();
            while (isEnd != "END")
            {
                bool isPalindrome = (ReverseN(isEnd));
                Console.WriteLine(isPalindrome);
                isEnd = Console.ReadLine();
            }
        }

        private static bool ReverseN(string num)
        {
            char[] arr = new char[num.Length];
            char[] reversedArr = new char[num.Length];
            for (int i = 0; i < num.Length; i++)
            {
                arr[i] = num[i];
            }

            int counter = num.Length;
            for (int i = 0; i < num.Length; i++)
            {
                reversedArr[i] = arr[counter - 1];
                counter--;
            }

            string reversedNum = string.Join("", reversedArr);
            if (num == reversedNum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
