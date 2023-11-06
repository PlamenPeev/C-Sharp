namespace _03.Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> second = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            int length = Math.Min(first.Count, second.Count);

            List<int> mergingList = new List<int>();

            for(int i = 0; i < length; i++)
            {
                mergingList.Add(first[0 + i]);
                mergingList.Add(second[0 + i]);
            }

               

            if(first.Count > second.Count)
            {
                for(int i = length; i < first.Count;i++)
                {
                    mergingList.Add(first[i]);
                }
            }
            else
            {
                for (int i = length; i < second.Count; i++)
                {
                    mergingList.Add(second[i]);
                }
            }
            Console.WriteLine(string.Join(" ", mergingList));


        }
    }
}