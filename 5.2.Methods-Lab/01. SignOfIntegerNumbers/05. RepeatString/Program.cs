using static System.Net.Mime.MediaTypeNames;

namespace _05._RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int repeatNum = int.Parse(Console.ReadLine());
            RepeatString(text, repeatNum);
        }

        static void RepeatString(string text, int num)
        {
            for(int i = 1; i <= num; i++)
            {
                Console.Write(text);
            }
        }
    }
}