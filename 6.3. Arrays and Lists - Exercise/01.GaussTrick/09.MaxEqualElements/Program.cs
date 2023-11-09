namespace _09.MaxEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
           
            int maxLength = 1;
            int currentLength = 1;
            int longestElement = numbers[0];
            int currentElement = numbers[0];

            for (int i = 1; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];

                if (currentNumber == numbers[i - 1])
                {
                    currentLength++;
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        longestElement = currentElement;
                    }
                }
                else
                {
                    currentLength = 1;
                    currentElement = currentNumber;
                }
            }

            List<int> longestSequence = new List<int>();
           
            for (int i = 0; i < maxLength; i++)
            {
                longestSequence.Add(longestElement);
                
            }

            
            Console.WriteLine(string.Join(" ", longestSequence));
        }
    }
}