namespace _01._Cinema;
class Program
{
    static void Main(string[] args)
    {
        string typeOfScreening = Console.ReadLine();
        int rows = int.Parse(Console.ReadLine());
        int columns = int.Parse(Console.ReadLine());

        double income = 0.0;
        int totalChairs = rows * columns;

        if (typeOfScreening == "Premiere")
        {
            income = totalChairs * 12.00;
        }
        else if (typeOfScreening == "Normal")
        {
            income = totalChairs * 7.50;
        }
        if (typeOfScreening == "Discount")
        {
            income = totalChairs * 5.00;
        }

        Console.WriteLine($"{income:F2} leva");
    }
}
