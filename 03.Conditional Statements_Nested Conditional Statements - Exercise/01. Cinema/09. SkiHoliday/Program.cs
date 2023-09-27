namespace _09._SkiHoliday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysToStay = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string assessment = Console.ReadLine();

            double price = 0.0;
            double totalPrice = 0.0;
            
            int nights = daysToStay - 1;

            if (typeOfRoom == "room for one person")
            {
                price = 118.00;
                if(daysToStay < 10)
                {
                    totalPrice = nights * price;
                }
                else if(daysToStay >= 10 && daysToStay <= 15)
                {
                    totalPrice = nights * price;

                }
                else if (daysToStay > 15)
                {
                    totalPrice = nights * price;

                }

            }
            else if (typeOfRoom == "apartment")
            {
                price = 155.00;
                if (daysToStay < 10)
                {
                    
                    totalPrice = nights * price * 0.7;
                }
                else if (daysToStay >= 10 && daysToStay <= 15)
                {
                    totalPrice = nights * price * 0.65;
                    
                }
                else if (daysToStay > 15)
                {
                    totalPrice = nights * price * 0.5;

                }

            }
            else if (typeOfRoom == "president apartment")
            {
                price = 235.00;
                if (daysToStay < 10)
                {
                    totalPrice = nights * price * 0.9;
                }
                else if (daysToStay >= 10 && daysToStay <= 15)
                {
                    totalPrice = nights * price * 0.85;

                }
                else if (daysToStay > 15)
                {
                    totalPrice = nights * price * 0.8;

                }

            }

            if (assessment == "positive")
            {
                totalPrice *= 1.25;
            }
            else if(assessment == "negative")
            {
                totalPrice *= 0.9;
            }


            Console.WriteLine($"{totalPrice:f2}");
            


        }
    }
}