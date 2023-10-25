using System;

namespace _07._GreaterOfTwoValuese
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            switch (input)
            {
                case "int":
                    int firstNum = int.Parse(Console.ReadLine());
                    int secondNum = int.Parse(Console.ReadLine());
                    int result = getMax(firstNum, secondNum);
                    Console.WriteLine(result);
                    break;
                case "char":
                    char first = char.Parse(Console.ReadLine());
                    char second = char.Parse(Console.ReadLine());
                    char resultChar = getMax(first, second);
                    Console.WriteLine(resultChar);
                    break;
                case "string":
                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();
                    string resultString = getMaxSting(firstString, secondString);
                    Console.WriteLine(resultString);
                    break;
                default:
                    break;
            }

        }

        private static string getMaxSting(String firstString, String secondString)
        {
            if (firstString.CompareTo(secondString) >= 0)
            {
                return firstString;
            }
            return secondString;
        }

        private static char getMax(char first, char second)
        {
            if (first > second)
            {
                return first;
            }
            return second;
        }

        private static int getMax(int firstNum, int secondNum)
        {
            return Math.Max(firstNum, secondNum);
        }

    }
}