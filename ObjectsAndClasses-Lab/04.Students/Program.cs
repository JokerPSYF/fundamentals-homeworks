using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    class Program
    {
        class Student
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public int age { get; set; }
            public string homeTown { get; set; }
        }
        static void Main(string[] args)
        {
            string[] lines = Console.ReadLine().Split();
            List<Student> students = new List<Student>();

            while (lines[0] != "end")
            {
                Student student = new Student();

                student.firstName = lines[0];
                student.lastName = lines[1];
                student.age = int.Parse(lines[2]);
                student.homeTown = lines[3];

                students.Add(student);

                lines = Console.ReadLine().Split();
            }

            string town = Console.ReadLine();
            foreach (Student student in students)
            {
                if (student.homeTown == town)
                {
                    Console.WriteLine($"{student.firstName} {student.lastName} is {student.age} years old.");
                }
            }
        }
    }
}
