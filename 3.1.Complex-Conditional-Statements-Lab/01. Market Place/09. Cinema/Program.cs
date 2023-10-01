namespace _09._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int seats = int.Parse(Console.ReadLine());

            int allSeats = rows * seats;
            double price = 0.0;

            if(type == "Premiere")
            {
                price = allSeats * 12.00;
            }
            else if (type == "Normal")
            {
                price = allSeats * 7.50;
            }
            else if (type == "Discount")
            {
                price = allSeats * 5.00;
            }

            Console.WriteLine("{0:f2}",price);
        }
    }
}