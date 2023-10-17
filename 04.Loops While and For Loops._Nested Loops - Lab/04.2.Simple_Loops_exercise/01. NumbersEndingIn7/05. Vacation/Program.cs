namespace _05._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double needMoney = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());

            int spendingCounter = 0;
            int counterOfDays = 0;
            bool isSpendingFiveDays = false;

            while(availableMoney < needMoney)
            {

                string typeOfAction = Console.ReadLine();
                double amount = double.Parse(Console.ReadLine());

                if(typeOfAction == "spend")
                {
                    spendingCounter++;
                    availableMoney = availableMoney - amount;
                    if(availableMoney < 0)
                    {
                        availableMoney = 0;
                    }
                    counterOfDays++;
                }
                else if(typeOfAction == "save")
                {
                    availableMoney += amount;
                    spendingCounter = 0;
                    counterOfDays++;
                }

                if(spendingCounter == 5)
                {
                    isSpendingFiveDays = true;
                    break;
                }

            }


            if (isSpendingFiveDays)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(counterOfDays);
            }
            else
            {
                Console.WriteLine($"You saved the money for {counterOfDays} days.");
            }

        }
    }
}