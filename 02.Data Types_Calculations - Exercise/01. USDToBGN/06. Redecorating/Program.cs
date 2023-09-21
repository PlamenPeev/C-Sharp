namespace _06._Redecorating
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int amountOfNylon = int.Parse(Console.ReadLine());
            int amountOfPaintInLiters = int.Parse(Console.ReadLine());
            int quantityOfThinnerInLiters = int.Parse(Console.ReadLine());
            int neededHoursForMaking = int.Parse(Console.ReadLine());

            double priceOfNylon = (amountOfNylon + 2) * 1.50;
            double priceOfPaint = (amountOfPaintInLiters * 0.1 + amountOfPaintInLiters) * 14.50;
            double priceOfThinner = quantityOfThinnerInLiters * 5.00;

            double totalPriceOfMaterials = priceOfNylon + priceOfPaint + priceOfThinner + 0.40;
            double amountForCraftsmen = (totalPriceOfMaterials * 0.3) * neededHoursForMaking;
            double total = totalPriceOfMaterials + amountForCraftsmen;

            Console.WriteLine(total);
        }
    }
}