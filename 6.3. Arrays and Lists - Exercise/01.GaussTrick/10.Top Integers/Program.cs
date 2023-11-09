namespace _10.Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            List<int> topIntegers = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                bool isTop = true;
                int currentNumber = numbers[i];

                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (currentNumber <= numbers[j])
                    {
                        isTop = false;
                        break;
                    }
                }

                if (isTop)
                {
                    topIntegers.Add(currentNumber);
                }
            }

            Console.WriteLine(string.Join(" ", topIntegers));
        }
    }
}