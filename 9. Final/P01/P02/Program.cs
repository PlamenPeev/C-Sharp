namespace P02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            int rotations = int.Parse(Console.ReadLine());



            for(int i = 1; i <= rotations; i++)
            {
                int currentNum = numbers[numbers.Count - 1];
                numbers.Insert(0, currentNum);
                numbers.RemoveAt(numbers.Count - 1);
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}