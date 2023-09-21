namespace _07._FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chickenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int veganMenu = int.Parse(Console.ReadLine());

            double priceOfChicken = chickenMenu * 10.35;
            double priceOfFish = fishMenu * 12.40;
            double priceOfVegan = veganMenu * 8.15;

            double costOfAllMenues = priceOfChicken + priceOfFish + priceOfVegan;
            double priceOfDessert = costOfAllMenues * 0.2;

            double orderPrice = costOfAllMenues + priceOfDessert + 2.50;
            Console.WriteLine(orderPrice);
        }
    }
}