namespace _04.Sum_Adjacent_Equal_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            int count = 0;
            for(int i  = count; i < numbers.Count; i++)
            {
                
                if (i == numbers.Count - 1) 
                {
                    break;
                }
                if (numbers[i] == numbers[i + 1])
                {
                    int sum = numbers[i] + numbers[i + 1];
                    numbers[i] = sum;
                    numbers.Remove(numbers[i + 1]);
                    count = 0;
                    i = -1;
                    
                }
                
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}