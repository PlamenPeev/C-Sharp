using System;

namespace _06._MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            NumOfPower(num, power);
        }


       private static void NumOfPower(int n, int p)
        {
            Console.WriteLine(Math.Pow(n,p));
        }
    }
}