using System;

namespace _9._1.SkiHoliday
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double singleRoom = 118.00;
            double apartment = 155.00;
            double president = 235.00;

            int days = int.Parse(Console.ReadLine()); ;
            string typeRoom = Console.ReadLine();
            string evaluation = Console.ReadLine();

            int nigths = days - 1;
            double price = 0;

            if (days < 10)
            {
                if (typeRoom == "room for one person")
                {
                    price = singleRoom * nigths;
                }
                else if (typeRoom == "apartment")
                {
                    price = apartment * nigths;
                    price *= 0.7;
                }
                else if (typeRoom == "president apartment")
                {
                    price = president * nigths;
                    price *= 0.9;
                }
            }
            else if (days >= 10 && days <= 15)
            {
                if (typeRoom == "room for one person")
                {
                    price = singleRoom * nigths;
                }
                else if (typeRoom == "apartment")
                {
                    price = apartment * nigths * 0.65;
                }
                else if (typeRoom == "president apartment")
                {
                    price = president * nigths * 0.85;
                }
            }
            else if (days > 15)
            {
                if (typeRoom == "room for one person")
                {
                    price = singleRoom * nigths;
                }
                else if (typeRoom == "apartment")
                {
                    price = apartment * nigths * 0.5;
                }
                else if (typeRoom == "president apartment")
                {
                    price = president * nigths * 0.8;
                }
            }

            if (evaluation == "positive")
            {
                price *= 1.25;
            }
            else if (evaluation == "negative")
            {
                price *= 0.9;
            }

            Console.Write($"{price:f2}");
        }
    }
}