namespace _9._MovingOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int availablePlace = width * length * height;

            
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Done")
                {
                    break;
                }
                
                 int boxes = int.Parse(input);
                 availablePlace -= boxes;

                if (availablePlace < 0)
                {
                    break;
                }

            }


            if (availablePlace >= 0)
            {
                Console.WriteLine($"{availablePlace} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(availablePlace)} Cubic meters more.");
            }
        }
    }
}