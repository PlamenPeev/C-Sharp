namespace _01._Magic_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            bool isNoMagicNumbers = true;
           
            for (int i = 1; i <= number; i++)
            {
                int currentNum = i;
                int digitSum = 0;
                bool isAllDigitsPrime = true;

                while(currentNum > 0)
                {
                    int digit = currentNum % 10;
                    currentNum = currentNum / 10;

                    bool isDigitPrime = digit == 2 || digit == 3 || digit == 5 || digit == 7;

                    if (isDigitPrime)
                    {
                        digitSum += digit;
                    }
                    else
                    {
                        isAllDigitsPrime = false;
                        isNoMagicNumbers = false;
                        break;
                    }
                }
                
                if(isAllDigitsPrime && digitSum % 2 == 0)
                {
                    Console.Write(i + " ");
                }
                


            }

            if(number == 1)
            {
                Console.WriteLine("no");
            }
        }
    }
}