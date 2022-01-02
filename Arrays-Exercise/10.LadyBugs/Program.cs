using System;
using System.Linq;

namespace _10.LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] ladyBugField = new int[size];
            string[] ladyBugsIndex = Console.ReadLine().Split(); // first place of bugs

            for (var i = 0; i < ladyBugsIndex.Length; i++)
            {
                var currentIndex = int.Parse(ladyBugsIndex[i]);
                if (currentIndex >= 0 && currentIndex < size)
                {
                    ladyBugField[currentIndex] = 1;
                }
            }

            string[] command = Console.ReadLine().Split();  //"{ladybug index} {direction} {fly length}"
            while (command[0] != "end")
            {

                int currentIndex = int.Parse(command[0]);
                string direction = command[1];
                int flyLength = int.Parse(command[2]);
                bool IsFirst = true;
                while (currentIndex >= 0 && currentIndex < size && ladyBugField[currentIndex] != 0)
                {
                    if (IsFirst)
                    {
                        ladyBugField[currentIndex] = 0;
                        IsFirst = false;
                    }


                    if (direction == "left")
                    {
                        currentIndex -= flyLength;

                        if (currentIndex >= 0 && currentIndex < size) // if it will be inside of the field
                        {
                            if (ladyBugField[currentIndex] == 0) //if there has a ladybug
                            {
                                ladyBugField[currentIndex] = 1;
                                break;
                            }
                            
                        }
                    }
                    else
                    {
                        currentIndex += flyLength;

                        if (currentIndex >= 0 && currentIndex < size) // if it will be inside of the field
                        {
                            if (ladyBugField[currentIndex] == 0) //if there has a ladybug
                            {
                                ladyBugField[currentIndex] = 1;
                                break;
                            }
                           
                        }
                    }
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", ladyBugField));
        }
    }
}
