namespace _07._SumOfDigitsCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine(); 


            while( number != "End") {
                int sum = 0;

                for (int i = 0; i <= number.Length - 1; i++)
                {
                    string currentDigit = number.Substring(i, 1);
                    int currentNum = int.Parse(currentDigit);
                    sum += currentNum;
                }
                Console.WriteLine($"Sum of digits = {sum}");
                sum = 0;

                number = Console.ReadLine();
            }
            Console.WriteLine("Goodbye");
        }
    }
}