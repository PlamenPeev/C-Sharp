﻿namespace _02.MagicNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            
           for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    for (int k = 0; k <= 9; k++)
                    {
                        if (i * j * k == number)
                        {
                            Console.Write($"{i}{j}{k} ");
                        }
                    }
                }
            }
        }

    }
}