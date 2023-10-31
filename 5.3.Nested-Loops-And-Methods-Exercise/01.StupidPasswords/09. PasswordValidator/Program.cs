using System;

namespace _09._PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            bool isValidLenght = isValidLenghts(input);
            if (!isValidLenght)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            bool isValidContent = isValidOnlyDigitsAndLetters(input);
            if (!isValidContent)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            bool isValidDigits = isValidTwoDigits(input);
            if (!isValidDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isValidContent && isValidDigits && isValidLenght)
            {
                Console.WriteLine("Password is valid");
            }
        }

        //It should contain only letters and digits
        private static bool isValidOnlyDigitsAndLetters(string input)
        {

            for (int i = 0; i < input.Length; i++)
            {
                char currentSymbol = input[i];
                if (!Char.IsLetter(currentSymbol) && !Char.IsDigit(currentSymbol))
                {
                    return false;
                }
            }
            return true;
        }

        //It should contain at least 2 digits 
        private static bool isValidTwoDigits(string input)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char currentSymbol = input[i];
                if (Char.IsDigit(currentSymbol))
                {
                    count++;
                }
            }
            //return count >= 2;
                    if (count >= 2)
                    {
                        return true;
                    } 
                    else 
                    {
                        return false;
                    }
        }

        //	It should contain 6 – 10 characters (inclusive)
        private static bool isValidLenghts(string input)
        {
            if (input.Length >= 6 && input.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}