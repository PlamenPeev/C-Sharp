namespace _03._Store_Boxes
{
    internal class Program
    {
        public class Item
        {
            public string Name { get; set; }
            public decimal Price { get; set; }


            public Item(string name, decimal price)
            {
                Name = name;
                Price = price;
            }
        }

        public class Box
        {
            public string SerialNumber { get; set; }
            public Item Item { get; set; }
            public int ItemQuantity { get; set; }
            public decimal PriceOfBox { get; set; }


            public Box(string serialNumber, Item item, int itemQuantity)
            {
                SerialNumber = serialNumber;
                Item = item;
                ItemQuantity = itemQuantity;
                PriceOfBox = itemQuantity * item.Price;

            }

        }
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            List<Box> boxes = new List<Box>();

            while (input != "end")
            {
                string[] data = input.Split(" ");
                string serialNumber = data[0];
                string itemName = data[1];
                int itemQuantity = int.Parse(data[2]);
                decimal itemPrice = decimal.Parse(data[3]);

             Item item = new Item(itemName, itemPrice);
             Box box = new Box(serialNumber, item, itemQuantity);

                boxes.Add(box);
              

                input = Console.ReadLine();
            }

            boxes = boxes.OrderByDescending(b => b.PriceOfBox).ToList();

            foreach (Box box in boxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceOfBox:F2}");
            }
        }
    }
}