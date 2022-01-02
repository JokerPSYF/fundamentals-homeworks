using System;
using System.Runtime.CompilerServices;

namespace _09.GreaterОfTwoValues
{
    class Program
    {
        private static int GetMaxInt(int a, int b)
        {
            int max = 0;
            if (a > b)
            {
                max = a;
            }
            else
            {
                max = b;
            }

            return max;
        }

        private static char GetMaxChar(char a, char b)
        {
            char max = ' ';
            if (a > b)
            {
                max = a;
            }
            else
            {
                max = b;
            }

            return max;
        }

        private static string GetMaxString(string a, string b)
        {
            int max = a.CompareTo(b);
            if (max > 0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            switch (type)
            {
                case "int":
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMaxInt(a, b));
                    break;
                case "char":
                    char c = char.Parse(Console.ReadLine());
                    char d = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMaxChar(c, d));
                    break;
                case "string":
                    string e = Console.ReadLine();
                    string f = Console.ReadLine();
                    Console.WriteLine(GetMaxString(e, f));
                    break;

            }
        }
    }
}
