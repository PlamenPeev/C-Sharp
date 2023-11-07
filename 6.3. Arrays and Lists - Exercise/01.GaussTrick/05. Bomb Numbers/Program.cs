namespace _05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            string[] input = Console.ReadLine().Split(" ");
            int bombNumber = int.Parse(input[0]);
            int bombPower = int.Parse(input[1]);

            int sum = 0;

            while(numbers.Contains(bombNumber))
            {
                int indexBomb = numbers.IndexOf(bombNumber);

                int left = Math.Max(0, indexBomb - bombPower);
                int right = Math.Min(numbers.Count - 1, indexBomb + bombPower);

                for (int i = right; i >= left; i--)
                {
                    numbers.RemoveAt(i);
                }

            }

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }
    }
}