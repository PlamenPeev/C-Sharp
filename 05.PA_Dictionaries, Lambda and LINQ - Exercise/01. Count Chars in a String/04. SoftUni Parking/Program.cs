namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string,string> parkingSystem = new Dictionary<string,string>();

            for(int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string command = input.Split(" ")[0];
                string studentName = input.Split(" ")[1];

                if(command.Equals("register"))
                {
                    string licensePlateNumber = input.Split(" ")[2];
                    if (!parkingSystem.ContainsKey(studentName))
                    {
                        parkingSystem.Add(studentName, licensePlateNumber);
                        Console.WriteLine($"{studentName} registered {licensePlateNumber} successfully");

                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parkingSystem[studentName]}");
                    }
                }
                else if (command.Equals("unregister"))
                {
                    if (!parkingSystem.ContainsKey(studentName))
                    {
                        Console.WriteLine($"ERROR: user {studentName} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{studentName} unregistered successfully");
                        parkingSystem.Remove(studentName);
                    }
                }
            }

           foreach(var student in parkingSystem)
            {
                Console.WriteLine($"{student.Key} => {student.Value}");
            }
        }
    }
}