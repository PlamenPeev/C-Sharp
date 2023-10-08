namespace _06._Product_OfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int countNegativNum = 0;

            if(num1 < 0)
            {
                countNegativNum++;
            }
            if (num2 < 0)
            {
                countNegativNum++;
            }
            if (num3 < 0)
            {
                countNegativNum++;
            }



            if (num1 == 0 || num2 == 0 || num3 == 0)
            {
                Console.WriteLine("zero");
            }
            else if(countNegativNum == 0 || countNegativNum == 2)
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("negative");
            }
        }
    }
}