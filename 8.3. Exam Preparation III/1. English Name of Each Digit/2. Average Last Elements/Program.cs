namespace _2._Average_Last_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            double sum = 0;

            for(int i = numbers.Length -1; i >= n; i--)
            {
                sum += numbers[i];
            }
            double average = sum / n;
            Console.WriteLine($"{average:f2}");
        }
    }
}