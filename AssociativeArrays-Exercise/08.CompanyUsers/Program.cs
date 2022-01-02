using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(" -> ");
            Dictionary<string, List<string>> companiesEmployees = new Dictionary<string, List<string>>();
            while (line[0] != "End")
            {
                string company = line[0];
                string employee = line[1];

                if (companiesEmployees.ContainsKey(company))
                {
                    if (companiesEmployees[company].Contains(employee))
                    {
                        
                    }
                    else
                    {
                        companiesEmployees[company].Add(employee);
                    }
                }
                else
                {
                    companiesEmployees.Add(company, new List<string>() { employee });
                }
                line = Console.ReadLine().Split(" -> ");
            }

            foreach (var keyValuePair in companiesEmployees.OrderBy(x => x.Key))
            {
                Console.WriteLine(keyValuePair.Key);
                foreach (var employee in keyValuePair.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
