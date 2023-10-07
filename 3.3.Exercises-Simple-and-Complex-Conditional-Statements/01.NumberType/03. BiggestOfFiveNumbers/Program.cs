namespace _03._BiggestOfFiveNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNum = int.MinValue;
            
            for(int i = 1; i <= 5; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (currentNum > maxNum)
                {
                    maxNum = currentNum;
                }
            }

            Console.WriteLine(maxNum);
        }
    }
}