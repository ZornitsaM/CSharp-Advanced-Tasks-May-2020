using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        string model;
        double fuelAmount;
        double fuelConsumptionPerKilometer;
        double travelledDistance = 0;

        public Car()
        {

        }

        public Car(string model, double fuelAmount, double fuelConsumptionFor1km)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptionFor1km;
        }

        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKilometer { get; set; }

        public double TravelledDistance { get; set; }
     
        public void Drive(string model, double amountOfKm)
        {
            if (this.FuelAmount >= this.FuelConsumptionPerKilometer * amountOfKm)
            {
                this.FuelAmount -= this.FuelConsumptionPerKilometer * amountOfKm;
                this.TravelledDistance += amountOfKm;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
