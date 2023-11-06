namespace _02._1.Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            while (numbers.Count > 1)
            {
                int count = 0;
                for (int i = 0; i < numbers.Count; i++)
                {
                    count++;
                    int num1 = numbers[i];
                    int num2 = numbers[i + 1];
                    int currentNum = num1 + num2;
                    numbers[i] = currentNum;

                    if (count == numbers.Count - 1)
                    {
                        numbers.Remove(numbers[numbers.Count - 1]);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}