namespace _04._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string command = input.Split(" ")[0];
                int element = int.Parse(input.Split(" ")[1]);

                if (command == "Add")
                {
                    numbers.Add(element);
                }
                else if (command == "Remove")
                {
                    
                    numbers.Remove(element);    
                }
                else if (command == "RemoveAt")
                {
                    
                    numbers.RemoveAt(element);
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(input.Split(" ")[2]);
                    numbers.Insert(index, element);
                }


                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}