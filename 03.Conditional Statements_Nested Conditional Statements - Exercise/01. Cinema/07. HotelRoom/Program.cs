using System.Diagnostics;

namespace _07._HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartmentPrice = 0;
            double totalStudioPrice = 0;
            double totalApartmentPrice = 0;

            if (month == "May" || month == "October")
            {
                studioPrice = 50;
                apartmentPrice = 65;

                if (nights > 7 && nights <= 14)
                {
                    totalStudioPrice = nights * (studioPrice * 0.95);
                    totalApartmentPrice = apartmentPrice * nights;
                }
                else if (nights > 14)
                {
                    totalStudioPrice = nights * (studioPrice * 0.70);
                    totalApartmentPrice = nights * (apartmentPrice * 0.90);
                }
                else
                {
                    totalStudioPrice = studioPrice * nights;
                    totalApartmentPrice = apartmentPrice * nights;
                }

            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 75.20;
                apartmentPrice = 68.70;
                if (nights > 14)
                {
                    totalStudioPrice = nights * (studioPrice * 0.80);
                    totalApartmentPrice = nights * (apartmentPrice * 0.90);
                }
                else
                {
                    totalStudioPrice = studioPrice * nights;
                    totalApartmentPrice = apartmentPrice * nights;
                }

            }
            else if (month == "July" || month == "August")
            {
                studioPrice = 76;
                apartmentPrice = 77;
                if (nights > 14)
                {
                    totalStudioPrice = studioPrice * nights;
                    totalApartmentPrice = nights * (apartmentPrice * 0.90);
                }
                else
                {
                    totalStudioPrice = studioPrice * nights;
                    totalApartmentPrice = apartmentPrice * nights;
                }
            }


            Console.WriteLine($"Apartment: {totalApartmentPrice:F2} lv.");
            Console.WriteLine($"Studio: {totalStudioPrice:F2} lv.");

        }
    }
}