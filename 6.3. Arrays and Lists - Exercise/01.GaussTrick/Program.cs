namespace _01.GaussTrick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> sumNumbers = new List<int>();

            int middleLine = numbers.Count / 2;
            if (numbers.Count % 2 == 0)
            {
                NewListOfSumNumbers(numbers, sumNumbers, middleLine);
                Console.WriteLine(string.Join(" ", sumNumbers));
            }
            else
            {
                NewListOfSumNumbers(numbers, sumNumbers, middleLine);
                sumNumbers.Add(numbers[middleLine]);
                Console.WriteLine(string.Join(" ", sumNumbers));
            }
        }

        private static void NewListOfSumNumbers(List<int> numbers, List<int> sumNumbers, int middleLine)
        {
            for (int i = 0; i < middleLine; i++)
            {
                int cureentNum = numbers[i] + numbers[numbers.Count - 1];
                sumNumbers.Add(cureentNum);
                numbers.Remove(numbers[numbers.Count - 1]);
            }
        }
    }
}