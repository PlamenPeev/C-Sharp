using System;

namespace _08._OnTimeForExam
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int startHourExam = int.Parse(Console.ReadLine());
            int startMinutesExam = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            int startExamInMinutes = startHourExam * 60 + startMinutesExam;
            int arrivalForExamInMinutes = arrivalHour * 60 + arrivalMinutes;
            int diffMinutes = startExamInMinutes - arrivalForExamInMinutes;

            if (diffMinutes < 0)
            {
                Console.WriteLine("Late");

                if (Math.Abs(diffMinutes) < 60)
                {
                    Console.WriteLine($"{ Math.Abs(diffMinutes)} minutes after the start");
                }
                else
                {
                    int hour = (Math.Abs(diffMinutes) / 60);
                    int minutes = Math.Abs(diffMinutes) % 60;
                    if (minutes < 10)
                    {
                        Console.WriteLine($"{ hour}:0{ minutes} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{ hour}:{ minutes} hours after the start");
                    }

                }

            }
            else if (diffMinutes >= 0 && diffMinutes <= 30)
            {
                Console.WriteLine("On time");

                if (diffMinutes == 0)
                {
                    Console.WriteLine();
                }
                else if (diffMinutes <= 30)
                {
                    Console.WriteLine($"{ diffMinutes} minutes before the start");
                }


            }
            else if (diffMinutes >= 0 && diffMinutes > 30)
            {
                Console.WriteLine("Early");

                if (diffMinutes < 60)
                {
                    Console.WriteLine($"{ diffMinutes} minutes before the start");
                }
                else
                {
                    int hour = diffMinutes / 60;
                    int minutes = diffMinutes % 60;
                    if (minutes < 10)
                    {
                        Console.WriteLine($"{ hour}:0{ minutes} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{ hour}:{ minutes} hours before the start");
                    }
                }
            }


        }
    }
}