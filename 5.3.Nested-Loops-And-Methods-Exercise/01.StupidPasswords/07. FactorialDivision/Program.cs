namespace _07._FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            double f1 = getFactorial(num1);
            double f2 = getFactorial(num2);

            double divide = f1 / f2;
            Console.WriteLine(divide);
        }

        private static double getFactorial(double num){
            double factorial = 1;
            for(double i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}