namespace _02._Min__Max_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());

            int maxNum = int.MinValue;
            int minNum = int.MaxValue;

            for(int i = 0; i < num; i++)
            {
                int currentNum = arr[i];

                if(currentNum > maxNum)
                {
                    maxNum = currentNum;
                }

                if (currentNum < minNum)
                {
                    minNum = currentNum;
                }
            }

            Console.WriteLine(maxNum);
            Console.WriteLine(minNum);

        }
    }
}