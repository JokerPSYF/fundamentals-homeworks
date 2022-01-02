using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bomb = elements[0];
            int radius = elements[1];

            while (list.Contains(bomb))
            {

                int bombSet = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] == bomb)
                    {
                        bombSet= i;
                        break;
                    }
                }

                int startIndex = bombSet - radius;
                int lastIndex = bombSet + radius;

                if (startIndex < 0 )
                {
                    startIndex = 0;
                }
                if (radius * 2 + 1 < list.Count )
                {
                    list.RemoveRange(startIndex, radius * 2 + 1);
                }
                else
                {
                    list.RemoveRange(startIndex, list.Count - (startIndex));
                }
            }

            Console.WriteLine(list.Sum());
        }
    }
}
