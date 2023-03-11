using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            List <Student> students = new List<Student>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                Student student = new Student(input[0], input[1], input[2]);
                students.Add(student);
            }

            students = students.OrderByDescending(i => i.Grade).ToList();
            for (int i = 0;i<students.Count;i++)
            {
                Console.WriteLine(students[i].ToString());
            }
        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Grade { get; set; }

        public Student(string name, string lastName, string grade) 
        { 
            FirstName = name;
            LastName = lastName;
            Grade = grade;
        }
        public override string ToString() =>
                $"{this.FirstName} {this.LastName}: {this.Grade}";
    }
}
