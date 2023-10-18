namespace _02._EqualSumOfEvenAndOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            for (int i = firstNum; i <= secondNum; i++)
            {
                string currentNumber = i.ToString();
                int evenSum = 0;
                int oddSun = 0;

                for (int j = 0; j < currentNumber.Length; j++)
                {
                    int currentDigit = int.Parse(currentNumber[j].ToString());

                    if (j % 2 == 0)
                    {
                        evenSum += currentDigit;
                    }
                    else
                    {
                        oddSun += currentDigit;
                    }
                }

                if (evenSum == oddSun)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}