namespace _08._TheGreaterNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            if(number1 > number2)
            {
                Console.WriteLine("Greater number: " + number1);
            }
            else if(number1 < number2)
            {
                Console.WriteLine("Greater number: " + number2);

            }
            else
            {
                Console.WriteLine("The two numbers are equal.");

            }
        }
    }
}