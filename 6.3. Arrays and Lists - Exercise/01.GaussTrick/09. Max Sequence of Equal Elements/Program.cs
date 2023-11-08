namespace _09._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> currentEqualElements = new List<int>();
            List<int> equalElements = new List<int>();

            int currentCount = 0;
           
            for(int i = 0; i < numbers.Count -1; i++)
            {

                
                int num1= numbers[i];
                int num2 = numbers[i + 1];
                int count = 0;
                if(num1 == num2)
                {
                    equalElements.Add(num1);
                    count++;
                    equalElements.Add(num2);
                    count++;
                }
                else
                {
                    for(int j = 0; j < equalElements.Count; j++)
                    {
                        currentEqualElements.Add(equalElements[j]); 

                    }
                   // currentEqualElements.RemoveAt(currentEqualElements.Count - 1);
                    
                    equalElements.Clear();
                    currentCount = count;
                    count = 0;
                    continue;
                }
               
            }

            Console.WriteLine(string.Join(" ", currentEqualElements));
            Console.WriteLine(string.Join(" ", equalElements));
        }
    }
}