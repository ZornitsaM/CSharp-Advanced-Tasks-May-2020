using _7._Raw_Data___Second;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < count; i++)
            {
                string[] inputInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = inputInfo[0];
                int engineSpeed = int.Parse(inputInfo[1]);
                int enginePower = int.Parse(inputInfo[2]);

                int cargoWeight = int.Parse(inputInfo[3]);
                string cargoType = inputInfo[4];

                Tire[] tires = new Tire[4];

                int counter = 0;

                for (int j = 5; j < inputInfo.Length; j += 2)
                {
                    double currentTirePressure = double.Parse(inputInfo[j]);
                    int curretnTireAge = int.Parse(inputInfo[j + 1]);
                    Tire tire = new Tire(currentTirePressure, curretnTireAge);
                    tires[counter] = tire;
                    counter++;
                }

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);
            }

            string command = Console.ReadLine();

            if (command == "flamable")
            {
                cars.Where(x => x.Engine.EnginePower > 250 && x.Cargo.CargoType == "flamable").ToList()
                    .ForEach(x => Console.WriteLine(x.Model));
            }

            else if (command == "fragile")
            {
                cars.Where(x => x.Cargo.CargoType == "fragile" && x.Tires.Any(p => p.TirePressure < 1)).ToList()
                    .ForEach(x => Console.WriteLine(x.Model));
            }
        }
    }
}
