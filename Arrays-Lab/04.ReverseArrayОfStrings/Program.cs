using System;
using System.Linq;

namespace _04.ReverseArrayОfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < array.Length / 2; i++)
            {
                string oldElement = array[i];
                   array[i] = array[array.Length - i - 1];
                   array[array.Length - i - 1] = oldElement;
            }

            Console.WriteLine(string.Join(" ", array));
        }
    }
}
