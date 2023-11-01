namespace _04._EvenAndOddSubtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ")
                .Select(int.Parse).ToArray();

            int sumEvens = 0;
            int sumOdds = 0;

            for(int i  = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sumEvens += numbers[i];
                }
                else
                {
                    sumOdds += numbers[i];
                }
            }

            int difference = sumEvens - sumOdds;
            Console.WriteLine(difference);
        }
    }
}