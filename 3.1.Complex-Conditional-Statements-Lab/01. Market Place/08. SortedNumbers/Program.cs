namespace _08._SortedNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num2 > num3)
            {
                Console.WriteLine("Descending");
            }
            else if(num1 < num2 && num2 < num3)
            {
                Console.WriteLine("Ascending");
            }
            else
            {
                Console.WriteLine("Not sorted");
            }
        }
    }
}