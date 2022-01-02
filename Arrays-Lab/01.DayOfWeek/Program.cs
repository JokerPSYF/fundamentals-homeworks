using System;

namespace _01.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] day = new string[]{ "Monday", "Tuesday", "Wednesday","Thursday", "Friday", "Saturday", "Sunday" };

            int dayNumber = int.Parse(Console.ReadLine());
            if (dayNumber >= 1 && dayNumber <= 7)
            {
                Console.WriteLine(day[(dayNumber - 1)]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
