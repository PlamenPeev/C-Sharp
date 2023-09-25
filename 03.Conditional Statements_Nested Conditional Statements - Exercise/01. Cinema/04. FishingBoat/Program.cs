namespace _04._FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int countOfFishermen = int.Parse(Console.ReadLine());

            double priceOfBoat = 0;

            if(season == "Spring")
            {
                priceOfBoat = 3000.0;
                if (countOfFishermen <= 6)
                {
                    priceOfBoat = priceOfBoat * 0.9;
                }
                else if (countOfFishermen >= 7 && countOfFishermen <= 11)
                {
                    priceOfBoat = priceOfBoat * 0.85;
                }
                else if(countOfFishermen >= 12)
                {
                    priceOfBoat = priceOfBoat * 0.75;
                }

                if(countOfFishermen % 2 == 0)
                {
                    priceOfBoat = priceOfBoat * 0.95;
                }
            }
            else if (season == "Summer" || season == "Autumn")
            {
                priceOfBoat = 4200;
                if (countOfFishermen <= 6)
                {
                    priceOfBoat = priceOfBoat * 0.9;
                }
                else if (countOfFishermen >= 7 && countOfFishermen <= 11)
                {
                    priceOfBoat = priceOfBoat * 0.85;
                }
                else if (countOfFishermen >= 12)
                {
                    priceOfBoat = priceOfBoat * 0.75;
                }

                if (countOfFishermen % 2 == 0 && season == "Summer")
                {
                    priceOfBoat = priceOfBoat * 0.95;
                }
            }
            else if (season == "Winter")
            {
                priceOfBoat = 2600;
                if (countOfFishermen <= 6)
                {
                    priceOfBoat = priceOfBoat * 0.9;
                }
                else if (countOfFishermen >= 7 && countOfFishermen <= 11)
                {
                    priceOfBoat = priceOfBoat * 0.85;
                }
                else if (countOfFishermen >= 12)
                {
                    priceOfBoat = priceOfBoat * 0.75;
                }
                if (countOfFishermen % 2 == 0)
                {
                    priceOfBoat = priceOfBoat * 0.95;
                }
            }

            if((budget - priceOfBoat) >= 0)
            {
                Console.WriteLine($"Yes! You have {(budget - priceOfBoat):F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(budget - priceOfBoat):F2} leva.");
            }


        }
    }
}