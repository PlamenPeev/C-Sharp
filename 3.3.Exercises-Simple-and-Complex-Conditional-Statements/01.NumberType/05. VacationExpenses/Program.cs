namespace _05._VacationExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string accommodation = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double price = 0;
            double finalPrice = 0;

            if(season == "Spring")
            {
                if (accommodation == "Hotel")
                {
                    price = days * 30;
                }
                else if(accommodation == "Camping")
                {
                    price = days * 10;
                }
                price *= 0.8;
            }
            else if (season == "Summer")
            {
                if (accommodation == "Hotel")
                {
                    price = days * 50;
                }
                else if (accommodation == "Camping")
                {
                    price = days * 30;
                }
                
            }
            else if (season == "Autumn")
            {
                if (accommodation == "Hotel")
                {
                    price = days * 20;
                }
                else if (accommodation == "Camping")
                {
                    price = days * 15;
                }
                price *= 0.7;
            }
            else if (season == "Winter")
            {
                if (accommodation == "Hotel")
                {
                    price = days * 40;
                }
                else if (accommodation == "Camping")
                {
                    price = days * 10;
                }
                price *= 0.9;
            }

            Console.WriteLine($"{price:f2}");
        }
    }
}