using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace _07.VehicleCatalogue
{
    class Program
    {
        public class Trucks
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public string Weight{ get; set; }
        }

        public class Cars
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public string HorsePower { get; set; }
        }
        [SuppressMessage("ReSharper.DPA", "DPA0002: Excessive memory allocations in SOH", MessageId = "type: Cars")]
        static void Main(string[] args)
        {
            string[] lines = Console.ReadLine().Split("/", StringSplitOptions.RemoveEmptyEntries);
            List<Trucks> trucks = new List<Trucks>();
            List<Cars> cars = new List<Cars>();

            while (lines[0] != "end")
            {
                if (lines[0] == "Truck")
                {
                    string brand = lines[1];
                    string model = lines[2];
                    string weight = lines[3];

                    Trucks truck = new Trucks()
                    {
                        Brand = brand,
                        Model = model,
                        Weight = weight
                    };
                    trucks.Add(truck);
                }
                else
                {
                    string brand = lines[1];
                    string model = lines[2];
                    string horsePower = lines[3];

                    Cars car = new Cars()
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = horsePower

                    };
                    cars.Add(car);
                }

                lines = Console.ReadLine().Split("/", StringSplitOptions.RemoveEmptyEntries);
            }

            if (cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (Cars car in cars.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (Trucks truck in trucks.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
}
