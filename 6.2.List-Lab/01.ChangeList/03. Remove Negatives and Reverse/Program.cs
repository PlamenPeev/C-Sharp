namespace _03._Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> positiveNums = new List<int>();

            for(int index = 0; index <= numbers.Count - 1; index++)
            {
                if (numbers[index] > 0) {
                    positiveNums.Add(numbers[index]);
                }
            }



            positiveNums.Reverse();
            if(positiveNums.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                foreach (int number in positiveNums)
                {
                    Console.Write(number + " ");
                }
            }
        }
    }
}