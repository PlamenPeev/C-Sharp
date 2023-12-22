using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace _01.Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                //"{first name} {second name} {grade}"
                string[] data = Console.ReadLine().Split(" ");

                string firstName = data[0];
                string lastName = data[1];
                double grade = double.Parse(data[2]);

                Student student = new Student(firstName,lastName,grade);
                students.Add(student);
            }

            students = students.OrderByDescending(s => s.Grade).ToList();

            foreach (Student student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:F2}");
            }
        }
    }
}