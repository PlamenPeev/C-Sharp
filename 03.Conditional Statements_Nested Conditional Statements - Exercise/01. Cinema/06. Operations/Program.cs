namespace _06._Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();

            int result = 0;

            if (symbol == "+")
            {
                result = N1 + N2;
                if(result % 2 == 0)
                {
                    Console.WriteLine($"{N1} {symbol} {N2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} {symbol} {N2} = {result} - odd");
                }
                
            }
            else if(symbol == "-")
            {
                result = N1 - N2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{N1} {symbol} {N2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} {symbol} {N2} = {result} - odd");
                }

            }
            else if (symbol == "*")
            {
                result = N1 * N2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{N1} {symbol} {N2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} {symbol} {N2} = {result} - odd");
                }

            }
            else if(symbol == "/")
            {
                if(N2 == 0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
                else
                {
                result = N1 / N2;
                Console.WriteLine($"{N1} {symbol} {N2} = {result:F2}");
                }
                
            }
            else if (symbol == "%")
            {
                if (N2 == 0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
                else
                {
                    result = N1 % N2;
                    Console.WriteLine($"{N1} {symbol} {N2} = {result}");
                }
                
            }
            


        }
    }
}