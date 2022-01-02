using System;

namespace _02.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalSum = 0;
            string[] line = Console.ReadLine().Split();

            string smallestWord = line[0];
            string biggerWord = line[1];
            if (line[0].Length > line[1].Length)
            {
                smallestWord = line[1];
                biggerWord = line[0];
            }

            for (int i = 0; i < smallestWord.Length; i++)
            {
                totalSum += line[0][i] * line[1][i]; // multipy the char from first word with the char of second
            }

            for (int i = smallestWord.Length; i < biggerWord.Length; i++)
            {
                totalSum += (char) biggerWord[i];
            }

            Console.WriteLine(totalSum);
        }
    }
}
