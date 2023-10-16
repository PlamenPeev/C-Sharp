namespace _03._OldBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string titleOfTheBook = Console.ReadLine();

            int count = 0;
            bool isBookFound = false;

            string nextBookName = Console.ReadLine();

            while(nextBookName != "No More Books")
            {
                if(nextBookName == titleOfTheBook)
                {
                    isBookFound = true;
                    break;
                }

                count++;
                nextBookName = Console.ReadLine();
            }

            if (isBookFound)
            {
                Console.WriteLine($"You checked {count} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {count} books.");
            }
        }
    }
}