using System;
using System.Globalization;
using System.Linq;

namespace Arrays_MoreExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int strings = int.Parse(Console.ReadLine());
            int[] numbers = new int[strings];

            for (int i = 0; i < strings; i++)
            {
                char[] names = Console.ReadLine().ToCharArray().ToArray();
                int sum = 0;
                for (int j = 0; j < names.Length; j++)
                {
                    switch (names[j])
                    {
                        case 'A':
                        case 'a':
                        case 'E':
                        case 'e':
                        case 'I':
                        case 'i':
                        case 'O':
                        case 'o':
                        case 'U':
                        case 'u': 
                            sum += names[j] * names.Length;
                            break;
                        default:
                            sum += names[j] / names.Length;
                            break;
                    }

                    numbers[i] = sum;
                }

            }
            Array.Sort(numbers);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);   
            }

        }
    }
}
