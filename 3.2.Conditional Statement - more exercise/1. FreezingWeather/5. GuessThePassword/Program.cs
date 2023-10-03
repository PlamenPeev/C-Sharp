namespace _5._GuessThePassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if(password == "s3cr3t!")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}