using System.Net.Sockets;

namespace _11._CoffeeShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfDrink = Console.ReadLine();
            string extra = Console.ReadLine();

            double coffeePrice = 1.00;
            double teaPrice = 0.60;
            double sugarPrice = 0.40;

            double price = 0.0;


            if (typeOfDrink == "coffee")
            {
                if(extra == "sugar")
                {
                    price = coffeePrice + sugarPrice;
                }
                else if(extra == "no")
                {
                    price = coffeePrice;
                }
            }
            else if (typeOfDrink == "tea")
            {
                if (extra == "sugar")
                {
                    price = teaPrice + sugarPrice;
                }
                else if (extra == "no")
                {
                    price = teaPrice;
                }
            }
            
            
                Console.WriteLine("Final price: ${0:f2}", price);
            
        }
    }
}