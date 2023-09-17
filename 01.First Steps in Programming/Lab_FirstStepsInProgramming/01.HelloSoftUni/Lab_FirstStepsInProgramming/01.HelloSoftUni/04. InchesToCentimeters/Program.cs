namespace _04._InchesToCentimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inches = double.Parse(Console.ReadLine());
            double centimeters = inches * 2.54;
            Console.WriteLine(centimeters);
        }
    }
}