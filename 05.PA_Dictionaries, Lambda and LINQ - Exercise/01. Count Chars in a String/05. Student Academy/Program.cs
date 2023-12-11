
using System.Linq;
namespace _05._Student_Academy
    
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string,List<double>> students = new Dictionary<string,List<double>>();

            for(int i = 0; i < n; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(student))
                {
                    students.Add(student, new List<double>());
                    
                }
                students[student].Add(grade);
            }

            var averageStudents = students.Where(s => s.Value.Average() >= 4.50);
            foreach(var student in averageStudents)
            {
                Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
            }
        }
    }
}