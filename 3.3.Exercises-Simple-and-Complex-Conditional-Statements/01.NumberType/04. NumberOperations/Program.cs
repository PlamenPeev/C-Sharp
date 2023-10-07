namespace _04._NumberOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            string operatorStr = Console.ReadLine();

            double result = 0;

            if(operatorStr == "+")
            {
                result = num1 + num2;
            }
            else if (operatorStr == "-")
            {
                result = num1 - num2;
            }
            else if (operatorStr == "*")
            {
                result = num1 * num2;
            }
            else if (operatorStr == "/")
            {
                result = num1 / num2;
            }

            Console.WriteLine($"{num1} {operatorStr} {num2} = {result:f2}");

        }
    }
}