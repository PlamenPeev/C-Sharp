namespace _08._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            int numberOfPieces = width * length;
            string input = Console.ReadLine();
            bool isNoMoreCake = false;
           

            while (true)
            {

                if( input == "STOP")
                {
                    break;
                }

                int takePieces = int.Parse(input);
                numberOfPieces -= takePieces;

                if(numberOfPieces < 0)
                {
                    isNoMoreCake = true;
                    break;
                }

                    input = Console.ReadLine();
            }

            if (isNoMoreCake)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(numberOfPieces)} pieces more.");
            }
            else
            {
                Console.WriteLine($"{numberOfPieces} pieces are left.");
            }
        }
    }
}