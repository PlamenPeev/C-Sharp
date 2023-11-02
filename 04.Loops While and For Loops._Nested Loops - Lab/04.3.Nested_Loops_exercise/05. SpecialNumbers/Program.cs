namespace _05._SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int specialNum = 0;
            for(int i = 1111; i <= 9999; i++)
            {
                int count = 0;
                string currentNum = i.ToString();
                for(int j = 0; j < currentNum.Length; j++)
                {
                    int currentDigit = int.Parse(currentNum[j].ToString());
                    if(currentDigit == 0)
                    {
                        break;
                    }
                    if(n % currentDigit == 0)
                    {
                        count++;
                    }
                }
                if(count == 4)
                {
                    specialNum = i;
                    Console.Write(specialNum + " ");
                }
            }
            Console.WriteLine();
        }
    }
}