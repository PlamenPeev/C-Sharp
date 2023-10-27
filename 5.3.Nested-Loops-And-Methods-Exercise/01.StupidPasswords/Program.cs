namespace _01.StupidPasswords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            validatePassword(number);
        }

        private static void validatePassword(int number)
        {
            for (int i = 2; i <= number; i++)
            {
                for (int j = 1; j <= number; j++)
                {

                    if (i % 2 == 0 && j % 2 != 0)
                    {
                        Console.Write($"{i}{j}{i * j} ");
                    }
                }
            }
        }
    }
}