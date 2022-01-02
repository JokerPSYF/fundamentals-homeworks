using System;
using System.Linq;

namespace _05.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                bool IsBigNum = true;
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] <= arr[j])
                    {
                        IsBigNum = false;
                    }

                }

                if (IsBigNum)
                {
                    Console.Write(arr[i] + " ");

                }

                //for (int j = i + 1; j < arr.Length; j++)
                //{
                //    if (arr[i] > arr[j] )
                //    {
                //        Console.Write(arr[i] + " ");
                //        break;
                //    }
                //}
            }

            //Console.Write(arr[arr.Length - 1]);
        }
    }
}
