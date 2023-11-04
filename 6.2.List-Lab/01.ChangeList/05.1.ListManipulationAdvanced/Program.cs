namespace _05._1.ListManipulationAdvanced
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

                }
                else if (command == "GetSum")
                {
                    int sum = 0;
                    foreach (int number in numbers)
                    {
                        sum += number;
                    }
                    Console.WriteLine(sum);
                }
                else if (command == "Filter")
                {

                    string condition = input.Split(" ")[1];
                    int number = int.Parse(input.Split(" ")[2]);


                    if (condition == ">")
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
                    else if (condition == "<")
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
                    else if (condition == ">=")
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
                    else if (condition == "<=")
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

                }


                input = Console.ReadLine();
            }

        }
    }
}