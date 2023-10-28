namespace _04._LetterCombinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char s = char.Parse(Console.ReadLine());
            char e = char.Parse(Console.ReadLine());
            char x = char.Parse(Console.ReadLine());

            int counter = 0;

            for(char i = s; i <= e; i++)
            {
                for (char j = s; j <= e; j++)
                {
                    for (char k = s; k <= e; k++)
                    {
                        if( !i.Equals(x) && !j.Equals(x) && !k.Equals(x))
                        {
                            Console.Write($"{i}{j}{k} ");
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine(counter);
        }
    }
}