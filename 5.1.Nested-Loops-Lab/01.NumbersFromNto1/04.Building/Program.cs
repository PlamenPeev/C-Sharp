using System;

namespace _04.Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for (int i = floors; i >= 1; i--)
            {
                string printLine = "";
                for (int j = 0; j < rooms; j++)
                {

                    if (i == floors)
                    {
                        printLine += $"L{ i}{ j} ";
                    }
                    else
                    {
                        if (i % 2 == 0)
                        {
                            printLine += $"O{ i}{ j} ";
                        }
                        else
                        {
                            printLine += $"A{ i}{ j} ";
                        }
                    }
                }
                Console.WriteLine(printLine);
            }
        }
    }
}