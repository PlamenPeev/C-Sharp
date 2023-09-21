namespace _05._TeachingMaterials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int packageOfPens = int.Parse(Console.ReadLine());
            int packageOfMarkers = int.Parse(Console.ReadLine());
            int boardCleanerPerLiter = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double priceOfPens = packageOfPens * 5.80;
            double priceOfMarkers = packageOfMarkers * 7.20;
            double priceOfCleaner = boardCleanerPerLiter * 1.20;

            double priceOfAll = priceOfPens + priceOfMarkers + priceOfCleaner;
            double totalAmount = priceOfAll - (priceOfAll * discount / 100.0);

            Console.WriteLine(totalAmount);
        }
    }
}