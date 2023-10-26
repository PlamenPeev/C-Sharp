namespace _08._1._MultiplyEvenByOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int result = getMultiplyEvensByOdds(number);
            Console.WriteLine(result);
        }

        private static int getMultiplyEvensByOdds(int number)
        {
            int evenSum = getEvenSum(number);
            int oddSum = getOddSum(number);
            return evenSum * oddSum;
        }

        private static int getOddSum(int number)
        {
            int sum = 0;
            while (Math.Abs(number) > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                number /= 10;
            }
            return sum;
        }

        private static int getEvenSum(int number)
        {
            int sum = 0;
            while (Math.Abs(number) > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                number /= 10;
            }
            return sum;
        }
    }
}