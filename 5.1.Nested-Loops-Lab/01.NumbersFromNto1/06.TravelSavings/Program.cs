namespace _06.TravelSavings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            while(input != "End") {

                string destination = input;
                double budjet = double.Parse(Console.ReadLine());
                double sum = 0;

                while (sum < budjet)
                {
                    double money = double.Parse(Console.ReadLine());
                    sum += money;
                    Console.WriteLine($"Collected: {sum:f2}");
                }

                if (sum >= budjet)
                {
                    Console.WriteLine($"Going to {destination}!");
                }
                sum = 0;
                
                input = Console.ReadLine();
            }

            
        }
    }
}