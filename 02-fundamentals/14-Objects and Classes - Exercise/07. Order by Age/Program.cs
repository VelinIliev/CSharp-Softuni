using System;
using System.Linq;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] info = input.Split().ToArray();
                string name = info[0];
                string id = info[1];
                int age = int.Parse(info[2]);

                bool isIdExist = false;
                
                foreach (Person p in persons)
                {
                    if (p.ID == id)
                    {
                        p.Name = name;
                        p.Age = age;
                        isIdExist = true;
                    }
                }

                if (!isIdExist)
                {
                    Person person = new Person(name, id, age);
                    persons.Add(person);
                }
            }

            List<Person> orderedPersons = persons.OrderBy(x => x.Age).ToList();

            foreach (Person p in orderedPersons)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
    class Person
    {
        public string Name {get; set;}
        public string ID {get; set;}
        public int Age {get; set;}
    
        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.ID = id;
            this.Age = age;
        }

        public override string ToString()
        {
            return $"{this.Name} with ID: {this.ID} is {this.Age} years old.";
        }
    }
}