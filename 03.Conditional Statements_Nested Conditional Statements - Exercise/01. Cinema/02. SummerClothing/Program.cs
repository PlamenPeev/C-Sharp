namespace _02._SummerClothing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temperature = int.Parse(Console.ReadLine());
            string timeOfTheDay = Console.ReadLine();

            string clothing = "";
            string shoes = "";

            if (temperature >= 10 && temperature <= 18)
            {
                if (timeOfTheDay == "Morning")
                {
                    clothing = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (timeOfTheDay == "Afternoon")
                {
                    clothing = "Shirt";
                    shoes = "Moccasins";
                }
                else if (timeOfTheDay == "Evening")
                {
                    clothing = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (temperature > 18 && temperature <= 24)
            {
                if (timeOfTheDay == "Morning")
                {
                    clothing = "Shirt";
                    shoes = "Moccasins";
                }
                else if (timeOfTheDay == "Afternoon")
                {
                    clothing = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (timeOfTheDay == "Evening")
                {
                    clothing = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (temperature >= 25)
            {
                if (timeOfTheDay == "Morning")
                {
                    clothing = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (timeOfTheDay == "Afternoon")
                {
                    clothing = "Swim Suit";
                    shoes = "Barefoot";
                }
                else if (timeOfTheDay == "Evening")
                {
                    clothing = "Shirt";
                    shoes = "Moccasins";
                }
            }


            Console.WriteLine($"It's {temperature} degrees, get your {clothing} and {shoes}.");
        }
    }
}