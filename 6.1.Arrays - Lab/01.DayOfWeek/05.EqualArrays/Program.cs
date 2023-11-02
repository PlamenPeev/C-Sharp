using System;

namespace _05.EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] numbers2 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();


            bool isIdentical = true;
           

            if(numbers1.Length != numbers2.Length) {

                isIdentical = false;
            }
            else
            {
                for(int i = 0; i < numbers1.Length; i++)
                {
                        if (numbers1[i] != numbers2[i])
                        {
                        isIdentical = false;
                        break;
                        }
                       
                }
            }

            if(isIdentical)
            {
                Console.WriteLine("Arrays are identical.");
            }
            else
            {
                Console.WriteLine("Arrays are not identical.");

            }



        }
    }
}