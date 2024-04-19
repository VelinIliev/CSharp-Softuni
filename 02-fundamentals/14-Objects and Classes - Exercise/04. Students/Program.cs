using System;
using System.Linq;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] info = Console.ReadLine().Split().ToArray();
                string firstName = info[0];
                string lastName = info[1];
                double grade = double.Parse(info[2]);
                Student student = new Student(firstName, lastName, grade);
                students.Add(student);
            }

            List<Student> orderedStudents = students.OrderByDescending(x => x.Grade).ToList();

            foreach (var student in orderedStudents)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public Student(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}: {this.Grade:f2}";
        }
    }
}
