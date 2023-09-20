namespace _03._DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositedAmount = double.Parse(Console.ReadLine());
            int termOfMonths = int.Parse(Console.ReadLine());
            double annualRate = double.Parse(Console.ReadLine());

            double amount = depositedAmount + termOfMonths * ((depositedAmount * annualRate / 100.0) / 12);

            Console.WriteLine(amount);
        }
    }
}