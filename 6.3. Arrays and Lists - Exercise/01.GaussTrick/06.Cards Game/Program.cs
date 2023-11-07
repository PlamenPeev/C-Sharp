using System.Collections.Generic;
using System.Numerics;

namespace _06.Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> second = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            while(first.Count > 0 && second.Count > 0)
            {
               
                
                    if (first[0] == second[0])
                    {
                    first.Remove(first[0]);
                    second.Remove(second[0]);
                    continue;
                    }

                     if (first[0] > second[0])
                     {
                        first.Add(first[0]);
                        first.Add(second[0]);

                    first.Remove(first[0]);
                    second.Remove(second[0]);
                    continue;
                     }

                     if (first[0] < second[0])
                    {
                        second.Add(second[0]);
                        second.Add(first[0]);

                    first.Remove(first[0]);
                    second.Remove(second[0]);
                    continue;
                     }
            }
                int sumFirst = first.Sum();
                int sumSecond = second.Sum();

                if (sumFirst > 0)
                {
                    Console.WriteLine($"First player wins! Sum: {sumFirst}");
                }
                else 
                {
                    Console.WriteLine($"Second player wins! Sum: {sumSecond}");
                }
            
        }
    }
}