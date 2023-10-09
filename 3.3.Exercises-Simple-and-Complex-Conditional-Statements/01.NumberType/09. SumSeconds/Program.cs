namespace _09._SumSeconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int sumTime = num1 + num2 + num3;
            int minutes = sumTime / 60;
            int seconds = sumTime % 60;

            string zeroSymbol = "";
            if(seconds < 10)
            {
                zeroSymbol = "0";
            }

            Console.WriteLine($"{minutes}:{zeroSymbol}{seconds}");
        }
    }
}