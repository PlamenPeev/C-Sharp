namespace _06._Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int goalReached = 10000;
            bool isGoalReached = false;
            bool isGoingHome = false;
            int sumOfSteps = 0;

            while(true)
            {
                
                if( input == "Going home")
                {
                    isGoingHome = true;
                    input = Console.ReadLine();
                    sumOfSteps += int.Parse(input);
                    break;
                }

                int steps = int.Parse(input);
                sumOfSteps += steps;

                if(sumOfSteps > goalReached)
                {
                    isGoalReached = true;
                    break;
                }
                input = Console.ReadLine();

            }

            if (isGoingHome)
            {
                if(sumOfSteps > goalReached)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{sumOfSteps - goalReached} steps over the goal!");
                }
                else
                {
                    Console.WriteLine($"{goalReached - sumOfSteps} more steps to reach goal.");
                }
            }
            else if( isGoalReached)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{sumOfSteps - goalReached} steps over the goal!");
            }




        }
    }
}