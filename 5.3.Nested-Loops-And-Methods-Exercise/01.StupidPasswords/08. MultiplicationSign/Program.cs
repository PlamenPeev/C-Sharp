namespace _08._MultiplicationSign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            multiplicationSign(n1, n2, n3);
        }

        private static void multiplicationSign(int n1, int n2, int n3)
        {
            int result = n1 * n2 * n3;

            if (result > 0)
            {
                Console.WriteLine("positive");
            }
            else if (result < 0)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("zero");
            }
        }
    }
}