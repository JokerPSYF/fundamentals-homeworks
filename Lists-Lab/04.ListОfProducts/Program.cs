using System;
using System.Collections.Generic;

namespace _04.ListОfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<string> fruits = new List<string>();
            for (int i = 0; i < lines; i++)
            {
                fruits.Add(Console.ReadLine());
            }
            SortTheFruits(fruits);
        }

        private static void SortTheFruits(List<string> fruits)
        {
            List<string> sortList = new List<string>();
            for (int i = 0; i < fruits.Count; i++)
            {
                for (int j = i + 1; j < fruits.Count; j++)
                {
                    if ((fruits[i]).CompareTo(fruits[j]) > 0)
                    {
                        string temp = fruits[i];
                        fruits[i] = fruits[j];
                        fruits[j] = temp;
                    }
                    
                }
            }
            for (int i = 1; i <= fruits.Count; i++)
            {
                Console.WriteLine($"{i}.{fruits[i - 1]}");
            }



        }
    }
}
