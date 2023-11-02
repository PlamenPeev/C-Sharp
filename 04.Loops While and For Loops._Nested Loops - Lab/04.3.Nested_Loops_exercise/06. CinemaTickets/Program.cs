namespace _06._CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            int studentTicket = 0;
            int standardTicket = 0;
            int kidTicket = 0;

            while (true)
            {
                string nameOfMovie = Console.ReadLine();
                if(nameOfMovie == "Finish")
                {
                    break;
                }
                int availableSeats = int.Parse(Console.ReadLine());

                int soldTickets = 0;
                while (soldTickets < availableSeats)
                {
                    string typeTicket = Console.ReadLine();
                    if (typeTicket == "End")
                    {
                        break;
                    }

                    soldTickets++;

                    if (typeTicket == "student")
                    {
                        studentTicket++; 
                    }
                    else if (typeTicket == "standard")
                    {
                        standardTicket++;
                    }
                    else if (typeTicket == "kid")
                    {
                        kidTicket++; 
                    }
                }
                Console.WriteLine($"{nameOfMovie} - {100.0 * soldTickets / availableSeats:f2}% full.");

            }
            int totalTickets = studentTicket + standardTicket + kidTicket;
            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{100.0 * studentTicket / totalTickets:f2}% student tickets.");
            Console.WriteLine($"{100.0 * standardTicket / totalTickets:f2}% standard tickets.");
            Console.WriteLine($"{100.0 * kidTicket / totalTickets:f2}% kids tickets.");
        }

    }
}