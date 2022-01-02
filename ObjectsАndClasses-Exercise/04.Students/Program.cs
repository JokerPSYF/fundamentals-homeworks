using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    class Program
    {
        class Student
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public string Grade { get; set; }

            public Student(string first, string lastName, string grade)
            {
                FirstName = first;
                LastName = lastName;
                Grade = grade;
            }

            public override string ToString()
            {
                return $"{ FirstName} { LastName}: {Grade}";
            }
        }
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split();
                Student student = new Student(line[0], line[1], line[2]);
                students.Add(student);
            }

            foreach (Student student in students.OrderByDescending(student => student.Grade))
            {
                Console.WriteLine(student);
            }
        }
    }
}
/* Ще си направя клас Студент, вътре конструктор който ще гетва име фамилия и оценка. разбира се ще направя пропертита на 'име' 'фамилия' 'оценка'
 * плюс оверайд ту стринг
 * След това в мейн класа правя лист от студенти като преди това взимам от входа колко са общо студентите и след това ги вкарам в листа
 * накрая с форич и ордер бай десендинг искарвам на изхода студентите според оценките им */