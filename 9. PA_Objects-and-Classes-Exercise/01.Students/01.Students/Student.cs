using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Students
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private double grade;

        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public double Grade { get {  return grade; } set {  grade = value; } }

        public Student(string firstName, string lastName, double grade) 
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;

        }


    }
}
