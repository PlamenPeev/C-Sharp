using System.Net.Sockets;

namespace _9._AreaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfFigure = Console.ReadLine();
            

            double area = 0;

            if (typeOfFigure == "square")
            {
                double size = double.Parse(Console.ReadLine());
                area = size * size;
                Console.WriteLine($"{area:F2}");
            }
            else if (typeOfFigure == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                area = width * height;
                Console.WriteLine($"{area:F2}");
            }
            else if (typeOfFigure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                area = Math.PI * Math.Pow(radius, 2);
                Console.WriteLine($"{area:F2}");
            }
            else
            {
                Console.WriteLine("Invalid figure.");
            }

           
        }
    }
}