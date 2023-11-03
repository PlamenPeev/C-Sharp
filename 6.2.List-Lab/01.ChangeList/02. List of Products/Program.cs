namespace _02._List_of_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> products = new List<string>();
            for(int i = 0; i < n; i++)
            {
                products.Add(Console.ReadLine());
            }

            products.Sort();
            int count = 1;
            foreach(string product in products) { 

                Console.WriteLine(count + "." + product);
                count++;
            }
        }
    }
}