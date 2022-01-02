using System;
using System.Text;
using System.Threading;


namespace HelicopterPericopter
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            while (true)
            {
                string a = @"===============^ ==    --    ";
                string b = @" -    --    == ^================";
                Thread.Sleep(1000);
                if (count == 0)
                {
                   // count++;
                   // Console.WriteLine(@" ===============^ ==    --    -");
                    Console.Write($"\r{a}", b);
                    Console.WriteLine(@"                ^              ");
                    Console.WriteLine(@" ''|        /--|||----------\");
                    Console.WriteLine(@"==<0>=======|      [ 0 ][ 0 ]\");
                    Console.WriteLine(@"   |/       \     ===   W  ===\");
                    Console.WriteLine(@"             \________________/");
                    Console.WriteLine(@"                ||       ||    ");
                    Console.WriteLine(@"             /----------------\");
                    Console.WriteLine();
                    Console.WriteLine();
                }
                //else
                //{
                //    count--;     //     -    --    ==^================
                //    Console.WriteLine(@"  -    --    == ^================");
                //    Console.WriteLine(@"                ^              ");
                //    Console.WriteLine(@" ''|/       /--|||----------\");
                //    Console.WriteLine(@"==<0>=======|      [ 0 ][ 0 ]\");
                //    Console.WriteLine(@"   |        \     ===   W  ===\");
                //    Console.WriteLine(@"             \________________/");
                //    Console.WriteLine(@"                ||       ||    ");
                //    Console.WriteLine(@"             /----------------\");
                //    Console.WriteLine();
                //    Console.WriteLine();
                //}
            }
            //for (int i = 0; i < 5; ++i)
            //{
            //    Console.Write("\r{0}%   ", i);
            //}
        }
    }
}
