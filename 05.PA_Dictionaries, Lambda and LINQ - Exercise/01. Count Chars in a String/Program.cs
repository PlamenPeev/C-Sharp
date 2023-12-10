namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char,int> countChars = new Dictionary<char,int>();

            for(int i = 0;i < input.Length;i++)
            {
                char symbol = char.Parse(input[i].ToString());
                if (symbol == ' ')
                {
                    continue;
                }

                if (!countChars.ContainsKey(symbol))
                {
                    countChars.Add(symbol, 1);
                }
                else
                {
                    countChars[symbol]++;
                }
                
            }

           foreach(var symbol in countChars)
            {
                Console.WriteLine($"{symbol.Key} -> {symbol.Value}");
            }
        }
    }
}