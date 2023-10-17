namespace _07._Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amount = double.Parse(Console.ReadLine());
            int amountInCents = (int)Math.Floor(amount * 100);

            int count = 0;

            while(amountInCents > 0)
            {
                if (amountInCents >= 200)
                {
                    amountInCents -= 200;
                    count++;
                }
                else if (amountInCents >= 100)
                {
                    amountInCents -= 100;
                    count++;
                }
                else if (amountInCents >= 50)
                {
                    amountInCents -= 50;
                    count++;
                }
                else if (amountInCents >= 20)
                {
                    amountInCents -= 20;
                    count++;
                }
                else if (amountInCents >= 10)
                {
                    amountInCents -= 10;
                    count++;
                }
                else if (amountInCents >= 5)
                {
                    amountInCents -= 5;
                    count++;
                }
                else if (amountInCents >= 2)
                {
                    amountInCents -= 2;
                    count++;
                }
                else if (amountInCents >= 1)
                {
                    amountInCents -= 1;
                    count++;
                }

            }

            Console.WriteLine(count);

        }
    }
}