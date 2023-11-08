namespace _08.Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());

            while (n > 0)
            {
                int currentNum = numbers[0];
                numbers.Add(currentNum);
                numbers.Remove(currentNum);
                n--;
            }
            

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}