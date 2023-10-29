namespace _05.HappyNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                for (int j = 0; j <= number; j++)
                {
                    for (int k = 0; k <= number; k++)
                    {
                        for(int l = 0; l <= number; l++)
                        {
                              if (i + j == number && k + l == number && i + j == k + l)
                        
                               Console.Write($"{i}{j}{k}{l} ");
                        }
                     
                    }
                }
            }
        }
    }
}