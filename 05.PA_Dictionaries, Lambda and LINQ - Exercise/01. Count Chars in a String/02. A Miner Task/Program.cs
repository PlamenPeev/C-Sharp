namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, int> minerTask = new Dictionary<string, int>();


            while(input != "stop")
            {
                string resource = input;
                int quantity = int.Parse(Console.ReadLine());

                if(!minerTask.ContainsKey(resource))
                {
                    minerTask.Add(resource, quantity);
                }
                else
                {
                    minerTask[resource] += quantity;
                }


                input = Console.ReadLine();
            }

            foreach(var task in minerTask)
            {
                Console.WriteLine($"{task.Key} -> {task.Value}");
            }
        }
    }
}