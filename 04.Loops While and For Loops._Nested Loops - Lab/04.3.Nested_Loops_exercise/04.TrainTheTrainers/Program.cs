namespace _04.TrainTheTrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juryMembers = int.Parse(Console.ReadLine());

            double totalScore = 0;
            int numOfPresantation = 0;
            while (true)
            {
                string nameOfPresantation = Console.ReadLine();

                if( nameOfPresantation == "Finish")
                {
                    break;
                }
                double sumOfGrades = 0;
                numOfPresantation++;
                
                for(int i = 1; i <= juryMembers; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sumOfGrades += grade;
                    totalScore += grade;
                }

                Console.WriteLine($"{nameOfPresantation} - {(sumOfGrades / juryMembers):f2}.");
            }

            Console.WriteLine($"Student's final assessment is {(totalScore / (numOfPresantation * juryMembers)):f2}.");
        }
    }
}