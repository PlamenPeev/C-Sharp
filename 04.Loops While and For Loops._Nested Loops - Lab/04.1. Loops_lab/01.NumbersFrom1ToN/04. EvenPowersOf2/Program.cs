namespace _04._EvenPowersOf2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;

            for (int i = 1; i <= n + 2; i ++)
            {
                if( i % 2 == 0)
                {
                   Console.WriteLine(num);
                    num = (int)Math.Pow(2, i);
                }
                
            }
        }
    }
}