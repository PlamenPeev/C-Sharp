namespace _12._CoffeeShopWithChecks
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

            bool isValid = false;


            if (typeOfDrink == "coffee")
            {
                if (extra == "sugar")
                {
                    price = coffeePrice + sugarPrice;
                    Console.WriteLine("Final price: ${0:f2}", price);
                }
                else if (extra == "no")
                {
                    price = coffeePrice;
                    Console.WriteLine("Final price: ${0:f2}", price);
                }
                else
                {
                    Console.WriteLine("Unknown extra");
                }

               
            }
            else if (typeOfDrink == "tea")
            {
                if (extra == "sugar")
                {
                    price = teaPrice + sugarPrice;
                    Console.WriteLine("Final price: ${0:f2}", price);
                }
                else if (extra == "no")
                {
                    price = teaPrice;
                    Console.WriteLine("Final price: ${0:f2}", price);
                }
                else
                {
                    Console.WriteLine("Unknown extra");
                }

                
            }
            else
            {
                Console.WriteLine("Unknown drink");
            }


            
        }
    }
}