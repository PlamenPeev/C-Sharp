namespace _06._VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            countVowels(text);
        }

        private static void countVowels(string text)
        {
            int counter = 0;

            for (int i = 0; i <= text.Length - 1; i++)
            {
                if (text[i] == 'a' || text[i] == 'A')
                {
                    counter++;
                }
                if (text[i] == 'e' || text[i] == 'E')
                {
                    counter++;
                }
                if (text[i] == 'i' || text[i] == 'I')
                {
                    counter++;
                }
                if (text[i] == 'o' || text[i] == 'O')
                {
                    counter++;
                }
                if (text[i] == 'u' || text[i] == 'U')
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}