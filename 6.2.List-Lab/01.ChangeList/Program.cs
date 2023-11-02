namespace _01.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while(input != "end")
            {
                string command = input.Split(" ")[0];
                int element = int.Parse(input.Split(" ")[1]);

                if(command == "Delete")
                {
                    numbers.RemoveAll(x => x == element);
                }
                else if(command == "Insert")
                {
                    int position = int.Parse(input.Split(" ")[2]);
                    numbers.Insert(position, element);
                }


                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}