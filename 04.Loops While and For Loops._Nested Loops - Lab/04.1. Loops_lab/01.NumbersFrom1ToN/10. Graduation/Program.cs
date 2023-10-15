using System.Diagnostics;

namespace _10._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int year = 0;
            double totalSumOfGrades = 0;
            int failed = 0;

            while (year < 12)
            {
                double grade = double.Parse(Console.ReadLine());

                if(grade < 4)
                {
                    failed++;
                }

                if(failed > 1)
                {
                    break;
                }

                year++;
                totalSumOfGrades += grade;
            }

            double averageGrade = totalSumOfGrades / 12.0;

            if (failed > 1)
            {
                Console.WriteLine($"{studentName} has been excluded at {year} grade");
            }
            else
            {
                Console.WriteLine($"{studentName} graduated. Average grade: {averageGrade:F2}");
            }
        }
    }
}