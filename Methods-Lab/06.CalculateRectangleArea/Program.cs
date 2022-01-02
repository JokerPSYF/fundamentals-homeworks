using System;

namespace _06.CalculateRectangleArea
{
    class Program
    {
        static double calculateTheVolume(double width, double height)
        {
            return width * height;
        }
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height= double.Parse(Console.ReadLine());
            Console.WriteLine(calculateTheVolume(width , height));

        }
    }
}
