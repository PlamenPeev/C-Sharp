using System.Runtime.Intrinsics.X86;

namespace _03._NewHome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfFlowers = Console.ReadLine();
            int countOfFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            //Roses	Dahlias	Tulips	Narcissus	Gladiolus
            double priceOfFlowers = 0;
            double finalPrice = 0;

            if(typeOfFlowers == "Roses")
            {
                if(countOfFlowers > 80)
                {
                priceOfFlowers = countOfFlowers * 5.0;
                    finalPrice = priceOfFlowers * 0.9;
                }
                else
                {
                    finalPrice = countOfFlowers * 5.0;
                }
               
            }
            else if (typeOfFlowers == "Dahlias")
            {
                if (countOfFlowers > 90)
                {
                    priceOfFlowers = countOfFlowers * 3.80;
                    finalPrice = priceOfFlowers * 0.85;
                }
                else
                {
                    finalPrice = countOfFlowers * 3.80;
                }

            }
            else if (typeOfFlowers == "Tulips")
            {
                if (countOfFlowers > 80)
                {
                    priceOfFlowers = countOfFlowers * 2.80;
                    finalPrice = priceOfFlowers * 0.85;
                }
                else
                {
                    finalPrice = countOfFlowers * 2.80;
                }

            }
            else if (typeOfFlowers == "Narcissus")
            {
                if (countOfFlowers < 120)
                {
                    priceOfFlowers = countOfFlowers * 3.0;
                    finalPrice = priceOfFlowers * 1.15;
                }
                else
                {
                    finalPrice = countOfFlowers * 3.0;
                }

            }
            else if (typeOfFlowers == "Gladiolus")
            {
                if (countOfFlowers < 80)
                {
                    priceOfFlowers = countOfFlowers * 2.50;
                    finalPrice = priceOfFlowers * 1.20;
                }
                else
                {
                    finalPrice = countOfFlowers * 2.50;
                }

            }

            if((budget - finalPrice) >= 0)
            {
                Console.WriteLine($"Hey, you have a great garden with " +
                    $"{countOfFlowers} {typeOfFlowers} and {(budget - finalPrice):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {Math.Abs(budget-finalPrice):f2} leva more.");
            }

        }
    }
}