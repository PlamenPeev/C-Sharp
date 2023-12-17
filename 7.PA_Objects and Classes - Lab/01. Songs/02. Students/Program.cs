namespace _02._Students
{
    internal class Program
    {
        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string HomeTown { get; set; }

            public Student(string firstName, string lastName, int age, string homeTown)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.Age = age;
                this.HomeTown = homeTown;
            }
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Student> students = new List<Student>();

            while(input != "end")
            {
                string[] data = input.Split(" ");
                string firstName = data[0];
                string lastName = data[1];
                int age = int.Parse(data[2]);
                string homeTown = data[3];

                Student student = new Student(firstName, lastName, age, homeTown);
                students.Add(student);

                input = Console.ReadLine();
            }

            string city = Console.ReadLine();

            students = students.Where(c => c.HomeTown == city).ToList();

            foreach(Student student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }
}