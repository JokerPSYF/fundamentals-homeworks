using System;

namespace _02.Grades
{
    class Program
    {
        //2.00 – 2.99 - "Fail"
        //3.00 – 3.49 - "Poor"
        //3.50 – 4.49 - "Good"
        //4.50 – 5.49 - "Very good"
        //5.50 – 6.00 - "Excellent"
        static void grades(double grades)
        {
            if (grades >= 2.00 && grades <= 2.99)
            {
                Console.WriteLine("Fail");
            }
            else if (grades >= 3.00 && grades <= 3.49)
            {
                Console.WriteLine("Poor");
            }
            else if (grades >= 3.50 && grades <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (grades >= 4.50 && grades <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            else if (grades >= 5.50 && grades <= 6.00)
            {
                Console.WriteLine("Excellent");
            }
        }
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            grades(grade);
        }
    }
}
