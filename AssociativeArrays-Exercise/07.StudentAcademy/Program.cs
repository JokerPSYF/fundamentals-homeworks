using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> studentsGrades = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (studentsGrades.ContainsKey(student))
                {
                    studentsGrades[student].Add(grade);
                }
                else
                {
                    studentsGrades.Add(student, new List<double>(){grade});
                }

            }

            Dictionary<string, double> greaterStudents = new Dictionary<string, double>();

            foreach (var studentsGrade in studentsGrades)
            {
                greaterStudents.Add(studentsGrade.Key, studentsGrade.Value.Average());
            }

            


            foreach (KeyValuePair<string, double> keyValuePair in greaterStudents.OrderByDescending
                (x => x.Value).Where(x => x.Value >= 4.50))
            {
                Console.WriteLine($"{keyValuePair.Key} -> {(keyValuePair.Value):f2}");
            }
        }
    }
}
