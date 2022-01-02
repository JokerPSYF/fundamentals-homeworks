using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            string[] line = Console.ReadLine().Split(" : ");

            while (line[0] != "end")
            {
                string course = line[0];
                string student = line[1];

                if (courses.ContainsKey(course))
                {
                    courses[course].Add(student);
                }
                else
                {
                    courses.Add(course, new List<string>(){student});
                }
                line = Console.ReadLine().Split(" : ");
            }

            foreach (KeyValuePair<string, List<string>> course in courses.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (string student in course.Value.OrderBy( x => x))
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
