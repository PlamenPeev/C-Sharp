namespace _08._BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int annualFee = int.Parse(Console.ReadLine());

            double sneakers = annualFee * 0.6;
            double team = sneakers * 0.8;
            double basketball = team * 0.25;
            double accessories = basketball * 0.2;

            double priceOfEquipment = annualFee + sneakers + team + basketball + accessories;
            Console.WriteLine(priceOfEquipment);
        }
    }
}