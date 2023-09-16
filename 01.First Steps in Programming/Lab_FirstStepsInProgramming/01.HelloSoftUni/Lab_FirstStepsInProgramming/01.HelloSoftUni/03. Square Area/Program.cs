namespace _03._Square_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lengthOfSide = int.Parse(Console.ReadLine());
            int area = lengthOfSide * lengthOfSide;
            Console.WriteLine(area);
        }
    }
}