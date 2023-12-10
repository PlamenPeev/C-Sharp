namespace _03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<double>> products = new Dictionary<string, List<double>>();

            
            while(input != "buy")
            {
                string product = input.Split(" ")[0];
                double price = double.Parse(input.Split(" ")[1]);
                double quantity = double.Parse(input.Split(" ")[2]);

                if(!products.ContainsKey(product) )
                {
                    products.Add(product, new List<double>());
                    products[product].Add(price);
                    products[product].Add(quantity);
                }
                else
                {
                    
                    products[product][0] = price;
                    products[product][1] += quantity;
                }

                input = Console.ReadLine();
            }

            foreach(var product in products) 
            {
                Console.WriteLine($"{product.Key} -> {(product.Value[0] * product.Value[1]):f2}");
                

            }
        }
    }
}