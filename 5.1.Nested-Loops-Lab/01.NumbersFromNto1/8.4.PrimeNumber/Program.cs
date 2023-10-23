namespace _8._4.PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());


            for (int num = start; num <= end; num++)
            {
                if (IsPrime(num))
                {
                    Console.Write(num + " ");
                }
            }


        }
        static bool IsPrime(int number)
        {
            if (number < 1)
            {
                return false;
            }


            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}