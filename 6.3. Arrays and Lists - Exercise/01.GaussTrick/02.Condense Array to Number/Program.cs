namespace _02.Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            

            while (numbers.Count > 1)
            {
                List<int> output = new List<int>();
                for(int i = 0; i < numbers.Count - 1; i++)
                {
                    int num1 = numbers[i];
                    int num2 = numbers[i + 1];
                    int currentNum = num1 + num2;
                    output.Add(currentNum);
                }
                numbers = output;
                
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}