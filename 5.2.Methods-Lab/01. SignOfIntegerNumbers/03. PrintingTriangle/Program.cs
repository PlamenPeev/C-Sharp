namespace _03._PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            printTriangle(n);

        }

        private static void printTriangle(int n)
        {
            printTop(n);
            printMiddle(n);
            printBottom(n);
        }

        private static void printTop(int n)
        {
            for (int i = 1; i < n; i++)
            {
                prinSingelLine(i);
            }

        }

        private static void printMiddle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        private static void printBottom(int n)
        {
            for (int i = n - 1; i >= 1; i--)
            {
                prinSingelLine(i);
            }

        }
        private static void prinSingelLine(int i)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}