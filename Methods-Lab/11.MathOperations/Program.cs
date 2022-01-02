using System;

namespace _11.MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            char operatr = char.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            Console.WriteLine(MathOperate(firstNum, operatr, secondNum));
        }

        private static double MathOperate(int firstNum, char operate, int secondNum)
        {
            int sum = 0;
            switch (operate)
            {
                case '/':
                    sum = firstNum / secondNum;
                    break;
                case '*':
                    sum = firstNum * secondNum;
                    break;
                case '+':
                    sum = firstNum + secondNum;
                    break;
                case '-':
                    sum = firstNum - secondNum;
                    break;
            }

            return sum;
        }
    }
}
