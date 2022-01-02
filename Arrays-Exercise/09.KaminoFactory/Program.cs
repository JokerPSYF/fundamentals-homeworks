using System;
using System.Linq;

namespace _09.KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int sequencelength = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int[] DNA = new int[sequencelength];
            int dnaSum = 0;
            int dnaCount = -1;
            int dnaStartIndex = -1;
            int dnaSamples = 0;
            int sample = 0;

            while (input != "Clone them!")
            {
                sample++;
                int[] currDNA = input.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int currCount = 0;
                int currStartIndex = 0;
                int currEndIndex = 0;
                int currDnasum = 0;
                bool IsCurrDNABetter = false;
                int count = 0;

                for (int i = 0; i < currDNA.Length; i++)
                {
                    if (currDNA[i] != 1)
                    {
                        count = 0;
                        continue;
                    }

                    count++;
                    if (count > currCount)
                    {
                        currCount = count;
                        currEndIndex = i;
                    }
                }

                currStartIndex = currEndIndex - currCount + 1;
                currDnasum = currDNA.Sum();

                if (currCount > dnaCount)
                {
                    IsCurrDNABetter = true;
                }
                else if (currCount == dnaCount)
                {
                    if (currStartIndex < dnaStartIndex)
                    {
                        IsCurrDNABetter = true;
                    }
                    else if (currStartIndex == dnaStartIndex)
                    {
                        if (currDnasum > dnaSum)
                        {
                            IsCurrDNABetter = true;
                        }
                    }
                }
                if (IsCurrDNABetter)
                {
                    DNA = currDNA;
                    dnaCount = currCount;
                    dnaStartIndex = currStartIndex;
                    dnaSum = currDnasum;
                    dnaSamples = sample;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {dnaSamples} with sum: {dnaSum}.");
            Console.WriteLine(string.Join(" ", DNA));
        }
    }
}
