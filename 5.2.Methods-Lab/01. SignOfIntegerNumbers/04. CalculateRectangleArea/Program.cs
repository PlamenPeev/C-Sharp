namespace _04._CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            printRectangleArea(width, length);
        }

        private static void printRectangleArea( int a, int b)
        {
            Console.WriteLine(a * b);
        }
    }
}