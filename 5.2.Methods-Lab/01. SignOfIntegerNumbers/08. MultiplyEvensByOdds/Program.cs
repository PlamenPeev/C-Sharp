namespace _08._MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            MultiplyEvensByOdds(number);
        }

        static void MultiplyEvensByOdds(int number)
        {
            int sumEven = 0;
            int sumOdd = 0;
          
            while(Math.Abs(number) > 0)
            {
                int currentNum = number % 10;
                if(currentNum % 2 == 0)
                {
                    sumEven += currentNum;
                }
                else
                {
                    sumOdd += currentNum;
                }
                number /= 10;
            }

            Console.WriteLine(sumEven * sumOdd);

        }
    }
}