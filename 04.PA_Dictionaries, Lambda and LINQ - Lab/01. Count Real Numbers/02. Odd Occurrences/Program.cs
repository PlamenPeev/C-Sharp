namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ").Select(w => w.ToLower()).ToArray();

            var counts = new Dictionary<string, int>();

          
            foreach (var word in words)
            {
                
                if (counts.ContainsKey(word))
                {
                    counts[word]++;
                }
                else
                {
                    counts[word] = 1;
                }
            }

            foreach (var word in counts)
            {
                if(word.Value % 2 != 0)
                {
                    Console.Write(word.Key + " ");
                }
                else
                {
                    continue;
                }
            }
        }
    }
}