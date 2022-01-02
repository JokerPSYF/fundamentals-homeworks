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
            public string age { get; set; }
            public string homeTown { get; set; }
        }
        static void Main(string[] args)
        {
            string[] lines = Console.ReadLine().Split();
            List<Student> students = new List<Student>();

            while (lines[0] != "end")
            {

                Student student = new Student();

                string firstName = lines[0];
                string lastName = lines[1];
                string age = lines[2];
                string homeTown = lines[3];

                if (IsStudentExisting(students, firstName, lastName))
                {
                    student = GetStudent(students, firstName, lastName);

                    student.firstName = firstName;
                    student.lastName = lastName;
                    student.age = age;
                    student.homeTown = homeTown;
                }
                else
                {
                    student.firstName = firstName;
                    student.lastName = lastName;
                    student.age = age;
                    student.homeTown = homeTown;

                    students.Add(student);
                }

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
        static bool IsStudentExisting(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.firstName == firstName && student.lastName == lastName)
                {
                    return true;
                }
            }

            return false;
        }

        static Student GetStudent(List<Student> students, string firstName, string lastName)
        {
            Student existingStudent = null;

            foreach (Student student in students)
            {
                if (student.firstName == firstName && student.lastName == lastName)
                {
                    existingStudent = student;
                }
            }

            return existingStudent;
        }

    }
}