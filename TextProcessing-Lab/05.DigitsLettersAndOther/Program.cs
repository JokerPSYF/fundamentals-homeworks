using System;
using System.Text;

namespace _05.DigitsLettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder symbols = new StringBuilder();

            foreach (char letter in line)
            {
                if (char.IsDigit(letter))
                {
                    digits.Append(letter);
                }
                else if (char.IsLetter(letter))
                {
                    letters.Append(letter);
                }
                else
                {
                    symbols.Append(letter);
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(symbols);
        }
    }
}
