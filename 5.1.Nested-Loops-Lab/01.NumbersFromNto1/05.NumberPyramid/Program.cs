using System;

namespace _05.NumberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int current = 1;
            bool isBigger = false;
            string printCurrentLine = "";

            for (int rows = 1; rows <= n; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    if (current > n)
                    {
                        isBigger = true;
                        break;
                    }
                    printCurrentLine += current + " ";
                    current++;
                }
                Console.WriteLine(printCurrentLine);
                printCurrentLine = "";
                if (isBigger)
                {
                    break;
                }
            }
        }
    }
}