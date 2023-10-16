using System.Diagnostics.Tracing;
using System.Xml.Linq;

namespace _04._ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfPoorGrades = int.Parse(Console.ReadLine());

            int counterPoorGrades = 0;
            double sumGrade = 0;
            int countGrades = 0;
            int numberOfProblems = 0;
            string currentProblem = "";

            while(true)
            {
                string problemName = Console.ReadLine();

                if (problemName == "Enough")
                {
                    break;
                }

                int grade = int.Parse(Console.ReadLine());

                sumGrade += grade;
                countGrades++;
                numberOfProblems++;
                currentProblem = problemName;

                if(grade <= 4)
                {
                    counterPoorGrades++;
                }

                if(counterPoorGrades == numOfPoorGrades)
                {
                    break;
                }

            }

            double averageGrade = sumGrade / countGrades;

            if(counterPoorGrades == numOfPoorGrades)
            {
                Console.WriteLine($"You need a break, {numOfPoorGrades} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {averageGrade:f2}");
                Console.WriteLine($"Number of problems: {numberOfProblems}");
                Console.WriteLine($"Last problem: {currentProblem}");

            }
        }
    }
}