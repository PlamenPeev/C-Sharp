namespace _07.Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> first = new List<int>();
            List<int> second = new List<int>();

            int num = int.Parse(Console.ReadLine());

            for(int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                int firstNum = int.Parse(input[0]);
                int secondNum = int.Parse(input[1]);

                if(i % 2 == 0)
                {
                    first.Add(firstNum);
                    second.Add(secondNum);
                }
                else
                {
                    first.Add(secondNum);
                    second.Add(firstNum);
                }
            }
            Console.WriteLine(string.Join(" ", first));
            Console.WriteLine(string.Join(" ", second));
        }
    }
}