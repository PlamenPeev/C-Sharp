using System.Runtime.Intrinsics.X86;

namespace _05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string holidayType = "";
            double finalBudget = 0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    holidayType = "Camp";
                    finalBudget = budget * 0.3;
                }
                else if(season == "winter")
                {
                    holidayType = "Hotel";
                    finalBudget = budget * 0.7;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    holidayType = "Camp";
                    finalBudget = budget * 0.4;
                }
                else if (season == "winter")
                {
                    holidayType = "Hotel";
                    finalBudget = budget * 0.8;
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                holidayType = "Hotel";
                finalBudget = budget * 0.9;
                     
            }

            
                Console.WriteLine($"Somewhere in {destination}");
                Console.WriteLine($"{holidayType} - {finalBudget:F2}");
                     


        }
    }
}