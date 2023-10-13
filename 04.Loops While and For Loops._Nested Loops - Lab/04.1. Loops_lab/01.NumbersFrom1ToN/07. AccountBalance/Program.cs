namespace _7._1._AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double sum = 0;

            while (command != "NoMoreMoney")
            {

                double currentNum = double.Parse(command);

                if (currentNum > 0)
                {
                    Console.WriteLine($"Increase: {currentNum:F2}");
                    sum += currentNum;
                }
                else
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                   
                
                command = Console.ReadLine();

            }

            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}