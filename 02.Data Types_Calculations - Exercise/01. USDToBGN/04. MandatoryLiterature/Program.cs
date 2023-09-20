namespace _04._MandatoryLiterature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOFPages = int.Parse(Console.ReadLine());
            int pagesForOneHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int totalTimePerBook = numberOFPages / pagesForOneHour;

            int hoursPerDay = totalTimePerBook / days;

            Console.WriteLine(hoursPerDay);
        }
    }
}