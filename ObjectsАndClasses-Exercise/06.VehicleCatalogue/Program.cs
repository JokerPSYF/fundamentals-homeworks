using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace _07.VehicleCatalogue
{
    class Program
    {
        //public class Trucks
        //{
        //    public string Brand { get; set; }
        //    public string Model { get; set; }
        //    public string HorsePower { get; set; }
        //}

        public class Vehicles
        {
            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public double HorsePower { get; set; }

            public Vehicles(string type, string model, string color, double horsePower)
            {
                Type = type;
                Model = model;
                Color = color;
                HorsePower = horsePower;
            }

            public override string ToString()
            {
                if (Type == "car")
                {
                    return
                        $"Type: Car\nModel: {Model}\nColor: {Color}\nHorsepower: {HorsePower}";
                }
                else
                {
                    return
                        $"Type: Truck\nModel: {Model}\nColor: {Color}\nHorsepower: {HorsePower}";

                }

            }
        }

        [SuppressMessage("ReSharper.DPA", "DPA0002: Excessive memory allocations in SOH", MessageId = "type: Vehicles")]
        static void Main(string[] args)
        {
            string[] lines = Console.ReadLine().Split();
            List<Vehicles> cars = new List<Vehicles>();
            List<Vehicles> onlyCars = new List<Vehicles>();
            List<Vehicles> onlyTrucks = new List<Vehicles>();


            while (lines[0] != "End")
            {
                string type = lines[0];
                string model = lines[1];
                string color = lines[2];
                double horsePower = double.Parse(lines[3]);

                Vehicles vehicle = new Vehicles(type, model, color, horsePower);

                cars.Add(vehicle);
                if (type == "car")
                {
                    Vehicles car = new Vehicles(type, model, color, horsePower);
                    onlyCars.Add(car);
                }
                else
                {
                    Vehicles truck = new Vehicles(type, model, color, horsePower);
                    onlyTrucks.Add(truck);
                }

                    lines = Console.ReadLine().Split();
            }

            string models = Console.ReadLine();
            while (models != "Close the Catalogue")
            {
                Vehicles thisModel = cars.FirstOrDefault(x => x.Model == models);
                Console.WriteLine(thisModel);
                models = Console.ReadLine();
            }

            double carsAvg =onlyCars.Any()? onlyCars.Average(x => x.HorsePower) : 0.0;
            double trucksAvg =onlyTrucks.Any()? onlyTrucks.Average(x => x.HorsePower) : 0.0;
            Console.WriteLine($"Cars have average horsepower of: {carsAvg:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAvg:f2}.");
        }
    }
}
/* Ще направим само един клас за всички типове коли и ще добавим тиш, модел, цвят и т.н. След това оверайд с информацията която трябва да изкараме на изхода.
 * Приемаме информация, вкарваме я в лист след като получим енд изкрваме информация модел който желаем и накрая извеждаме средно статистическите коне на колите и камионите */