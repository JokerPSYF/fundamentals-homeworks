using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.OrderByAge
{
    class Program
    {
        class Person
        {
            public string Name { get; set; }

            public string Id { get; set; }

            public int Age { get; set; }

            public override string ToString()
            {
                return $"{Name} with ID: {Id} is {Age} years old.";
            }
        }
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string[] info = Console.ReadLine().Split();

            while (info[0] != "End")
            {
                string name = info[0];
                string id = info[1];
                int age = int.Parse(info[2]);
                if (people.Any(x => x.Id.Contains(id)))
                {
                    foreach (Person person in people)
                    {
                        if (person.Id == id)
                        {
                            person.Name = name;
                            person.Age = age;
                        }
                    }
                }
                else
                {
                    Person person = new Person() { Name = name, Id = id, Age = age };
                    people.Add(person);
                }
                info = Console.ReadLine().Split();
            }

            foreach (Person person in people.OrderBy(x => x.Age))
            {
                Console.WriteLine(person);
            }
        }
    }
}
