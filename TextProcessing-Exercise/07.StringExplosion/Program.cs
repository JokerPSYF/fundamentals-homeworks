using System;
using System.Text;

namespace _07.StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder line = new StringBuilder(Console.ReadLine());
            int strength = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == '>')
                {
                    strength += int.Parse(line[i + 1].ToString());

                    while (strength > 0)
                    {
                        if (line[i + 1] == '>')
                        {
                            break;
                        }
                        else
                        {
                            line.Remove(i + 1, 1);
                            strength--;
                        }
                        if (i + 1 >= line.Length)
                        {
                            Console.WriteLine(line);
                            return;
                        }
                    }



                }
            }

            Console.WriteLine(line);
        }
    }
}
