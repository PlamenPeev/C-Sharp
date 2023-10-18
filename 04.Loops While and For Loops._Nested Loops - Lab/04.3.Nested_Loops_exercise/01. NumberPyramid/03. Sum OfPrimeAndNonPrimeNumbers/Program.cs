namespace _03._Sum_OfPrimeAndNonPrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int primeSum = 0;
            int nonPrimeSum = 0;


            string input = Console.ReadLine();
            while ( input != "stop")
            {
                int number = int.Parse(input);

                if(number < 0)
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }

                //bool isPrime = true;
                //for (int i = 2; i < number; i++)
                //{
                //    if (number % i == 0)
                //    {
                //        isPrime = false;
                //        break;
                //    }
                //}

                //if (isPrime == true)
                //{
                //    primeSum += number;
                //}
                //else
                //{
                //    nonPrimeSum += number;
                //}


                int divisors = 0;
                for (int i = 1; i <= number; i++)
                    if (number % i == 0)
                        divisors++;

                if (divisors == 2)
                {
                    primeSum += number;
                }
                else
                {
                    nonPrimeSum += number;
                }


                input = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}