namespace _02._Enter_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            int currentNum = 1;
            while(numbers.Count < 10)
            {
                try
                {
                    int num = ReadNumber(currentNum, 100);
                    numbers.Add(num);
                    currentNum = num;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine($"Your number is not in range {currentNum} - 100!");
                }
                catch (FormatException)
                {
                    
                    Console.WriteLine("Invalid Number!");
                }
               
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
        static int ReadNumber(int start, int end)
        {
            int num = int.Parse(Console.ReadLine());

            if(num <= start || num >= end)
            {
                throw new ArgumentException();
            }

            return num;
        }
    }
}