namespace _02._HalfSumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int maxNum = int.MinValue;

            for ( int i = 1; i <= n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                sum += currentNum;

                if (currentNum > maxNum)
                {
                    maxNum = currentNum;
                }

            }

          
             int finalSum = sum - maxNum;

            if (maxNum == finalSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxNum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(maxNum - (sum - maxNum))}");
            }
        }
    }
}