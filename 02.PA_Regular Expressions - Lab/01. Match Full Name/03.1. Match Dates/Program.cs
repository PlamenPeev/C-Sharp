using System.Text.RegularExpressions;

namespace _03._1._Match_Dates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"\b(?<day>\d{2})(?<separator>[\/\-\.])(?<month>[A-Z]{1}[a-z]{2})\k<separator>(?<year>\d{4})\b";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);



            foreach (Match match in matches)
            {
                Console.WriteLine($"Day: {match.Groups[1]}, Month: {match.Groups[3]}, Year: {match.Groups[4]}");

            }

        }
    }
}