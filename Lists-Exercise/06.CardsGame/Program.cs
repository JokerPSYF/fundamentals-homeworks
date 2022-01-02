using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (firstPlayer.Count > 0 && secondPlayer.Count > 0)
            {
                if (firstPlayer[0] > secondPlayer[0])
                {
                    int bestCard = firstPlayer[0];
                    int loserCard = secondPlayer[0];

                    firstPlayer.RemoveAt(0);
                    secondPlayer.RemoveAt(0);

                    firstPlayer.Add(loserCard);
                    firstPlayer.Add(bestCard);
                }
                else if (secondPlayer[0] > firstPlayer[0])
                {
                    int bestCard = secondPlayer[0];
                    int loserCard = firstPlayer[0];

                    firstPlayer.RemoveAt(0);
                    secondPlayer.RemoveAt(0);

                    secondPlayer.Add(loserCard);
                    secondPlayer.Add(bestCard);
                }
                else
                {
                    firstPlayer.RemoveAt(0);
                    secondPlayer.RemoveAt(0);
                }
            }

            if (firstPlayer.Count > secondPlayer.Count)
            {
                Console.WriteLine($"First player wins! Sum: {firstPlayer.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondPlayer.Sum()}");
            }

        }
    }
}
