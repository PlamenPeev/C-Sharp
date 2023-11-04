namespace _05._ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<string> currentList = new List<string>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string command = input.Split(" ")[0];

                if (command == "Contains")
                {
                    int number = int.Parse(input.Split(" ")[1]);

                    if (numbers.Contains(number))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                    currentList.Add("Contains");
                }
                else if (command == "PrintEven")
                {
                    foreach (int number in numbers)
                    {
                        if (number % 2 == 0)
                        {
                            Console.Write(number + " ");
                        }
                    }
                    Console.WriteLine();
                    currentList.Add("PrintEven");
                }
                else if (command == "PrintOdd")
                {
                    foreach (int number in numbers)
                    {
                        if (number % 2 != 0)
                        {
                            Console.Write(number + " ");
                        }
                    }
                    Console.WriteLine();
                    currentList.Add("PrintOdd");

                }
                else if (command == "GetSum")
                {

                    Console.WriteLine(numbers.Sum());
                    currentList.Add("GetSum");

                }
                else if (command == "Filter")
                {
                    string condition = input.Split(" ")[1];
                    int number = int.Parse(input.Split(" ")[2]);

                    
                    if (condition.Equals(">"))
                    {
                        foreach (int num in numbers)
                        {
                            if (num > number)
                            {
                                Console.Write(num + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                    else if (condition.Equals("<"))
                    {
                        foreach (int num in numbers)
                        {
                            if (num < number)
                            {
                                Console.Write(num + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                    else if (condition.Equals(">="))
                    {
                        foreach (int num in numbers)
                        {
                            if (num >= number)
                            {
                                Console.Write(num + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                    else if (condition.Equals("<="))
                    {
                        foreach (int num in numbers)
                        {
                            if (num <= number)
                            {
                                Console.Write(num + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                    currentList.Add("Filter");
                }
                input = Console.ReadLine();
            }

            bool isValid = true;
            if (currentList.Contains("Filter"))
            {
                
                    isValid = false;
                
            }

            if (isValid)
            {
                foreach (int number in numbers)
                {
                Console.Write(number + " ");
                }
            }
            
        }
    }
}