using System.Numerics;
using System;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                string input = Console.ReadLine();
                
                if (input == "end")
                {
                    break;
                }

                string[] info = input.Split().ToArray();

                string firstName = info[0];
                string lastName = info[1];
                int age = int.Parse(info[2]);
                string hometown = info[3];

                if (IsStudentExist(students, firstName, lastName))
                {
                    Student student = GetStudent(students, firstName, lastName);
                    student.firstName = firstName;
                    student.lastName = lastName;
                    student.age = age;
                    student.hometown = hometown;
                }
                else
                {
                    Student student = new Student();
                    student.firstName = firstName;
                    student.lastName = lastName;
                    student.age = age;
                    student.hometown = hometown;
                
                    students.Add(student);
                }
            }
            
            string filter = Console.ReadLine();
            

            List<Student> filteredStudents = students.Where(x => x.hometown == filter).ToList();

            foreach (Student fs in filteredStudents)
            {
                Console.WriteLine($"{fs.firstName} {fs.lastName} is {fs.age} years old.");
            }
        } 
        public class Student
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public int age { get; set; }
            public string hometown { get; set; }
        }

        static bool IsStudentExist(List<Student> students, string firstName, string lastName)
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