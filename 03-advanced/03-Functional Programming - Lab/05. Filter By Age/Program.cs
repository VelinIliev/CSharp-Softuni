using System;
using System.Collections.Generic;
using System.Linq;

namespace FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] info = Console.ReadLine().Split(", ");
                string name = info[0];
                int age = int.Parse(info[1]);
                Person person = new Person(name, age);
                
                persons.Add(person);
            }

            string conditionAge = Console.ReadLine();
            int ageToCompare = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Func<Person, bool> conditionFilter = conditionAge switch
            {
                "younger" => p => p.Age < ageToCompare,
                "older" => p => p.Age >= ageToCompare,
            };
            Func<Person, string> formatFilter = format switch
            {
                "name" => p => $"{p.Name}",
                "age" => p => $"{p.Age}",
                "name age" => p => $"{p.Name} - {p.Age}",
            };
            persons
                .Where(conditionFilter)
                .Select(formatFilter)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }

    class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}