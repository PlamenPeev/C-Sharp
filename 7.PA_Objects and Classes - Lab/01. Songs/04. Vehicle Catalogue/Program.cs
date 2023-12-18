namespace _04._Vehicle_Catalogue
{
    internal class Program
    {
        public class Truck
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public string Weight { get; set; }


            public Truck(string brand, string model, string weight)
            {
                Brand = brand;
                Model = model;
                Weight = weight;
            }
        }

        public class Car
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public string HorsePower { get; set; }

            public Car(string brand, string model, string horsePower)
            {
                Brand = brand;
                Model = model;
                HorsePower = horsePower;
            }
        }

        public class Catalog
        {
            public List<Car> Cars { get; set; }
            public List<Truck> Trucks { get; set; }

            public Catalog()
            {
                Cars = new List<Car>();
                Trucks = new List<Truck>();
            }

        }
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            Catalog catalog = new Catalog();

            while (input != "end")
            {
                string[] data = input.Split("/");
                string type = data[0];
                string brand = data[1];
                string model = data[2];
                
                if (type == "Car")
                {
                    string horsePower = data[3];
                    Car car = new Car(brand, model, horsePower);
                    catalog.Cars.Add(car);
                }
                else if(type == "Truck")
                {
                    string weight = data[3];
                    Truck truck = new Truck(brand, model, weight);
                    catalog.Trucks.Add(truck);
                }


                input = Console.ReadLine();
            }

            if(catalog.Cars.Count > 0)
            {
                List<Car> cars = catalog.Cars.OrderBy(c => c.Brand).ToList();
                Console.WriteLine("Cars:");
                foreach(Car car in cars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if(catalog.Trucks.Count > 0)
            {
                List<Truck> trucks = catalog.Trucks.OrderBy(t => t.Brand).ToList();
                Console.WriteLine("Trucks:");
                foreach(Truck truck in trucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
}