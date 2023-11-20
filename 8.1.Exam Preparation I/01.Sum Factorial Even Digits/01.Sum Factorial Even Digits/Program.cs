namespace _01._Sum_Factorial_Even_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int sum = 0;

            for(int i = 0; i < number.Length;i++)
            {
                int currentDigit = int.Parse(number[i].ToString());

                if(currentDigit % 2 == 0)
                {
                    int f1 = getFactorial(currentDigit);
                    sum += f1;
                }
            }

            Console.WriteLine(sum);
        }

        private static int getFactorial(int num)
        {
            int factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}