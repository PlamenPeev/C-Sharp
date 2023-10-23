namespace _01._SignOfIntegerNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintSign(number);
        }

        private static void PrintSign(int number) { 
        
        if(number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
        else if(number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        
        }
    }
}