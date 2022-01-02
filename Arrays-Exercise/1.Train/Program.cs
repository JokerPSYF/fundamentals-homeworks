using System;
using System.Diagnostics.CodeAnalysis;

namespace _1.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] peoples = new int[wagons];
            int sum = 0;

            for (int i = 0; i < peoples.Length; i++)
            {
                peoples[i] = int.Parse(Console.ReadLine());
                sum += peoples[i];
            }

            foreach (var people in peoples)
            {
                Console.Write(people + " ");
            }

            Console.WriteLine();
            Console.WriteLine(sum);

        }
    }
}
