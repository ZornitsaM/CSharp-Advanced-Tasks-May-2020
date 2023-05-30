using System;
using System.Linq;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int numberCars = int.Parse(Console.ReadLine());

            Car car = new Car(null, 0, 0);
            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberCars; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumptionFor1km = double.Parse(input[2]);
                car = new Car(model, fuelAmount, fuelConsumptionFor1km);
                cars.Add(car);
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] currendCommand = command.Split();
                string carModel = currendCommand[1];
                double amountKM = double.Parse(currendCommand[2]);
                var currentCar = cars.Where(x => x.Model == carModel).ToList().First();
                currentCar.Drive(carModel, amountKM);
                command = Console.ReadLine();
            }

            foreach (Car currentCar in cars)
            {
                Console.WriteLine($"{currentCar.Model} {currentCar.FuelAmount:f2} {currentCar.TravelledDistance}");
            }
        }
    }
}
