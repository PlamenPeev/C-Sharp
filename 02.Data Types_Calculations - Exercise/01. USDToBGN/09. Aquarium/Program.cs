namespace _09._Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            int volumeOfAquarium = length * width * height;
            double volumeInLiters = volumeOfAquarium * 0.001;

            double neededLiters = volumeInLiters * (1 - percentage / 100.0);
            Console.WriteLine($"{neededLiters:f2}");
        }
    }
}