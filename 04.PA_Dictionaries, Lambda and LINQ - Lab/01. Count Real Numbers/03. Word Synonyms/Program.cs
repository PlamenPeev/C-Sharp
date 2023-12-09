namespace _03._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var result = new Dictionary<string, List<string>>();
            
            for(int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonim = Console.ReadLine();

                if(!result.ContainsKey(word))
                {
                    result.Add(word, new List<string>());
                    result[word].Add(synonim);
                }
                else
                {
                    result[word].Add(synonim);
                }
            }

            foreach(var word in result)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}"); 
                
            }
            
        }
    }
}