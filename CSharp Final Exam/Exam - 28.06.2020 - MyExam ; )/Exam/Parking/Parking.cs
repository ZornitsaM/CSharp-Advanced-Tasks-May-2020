using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Parking
{
    public class Parking
    {

        private string type;
        private int capacity;
        private List<Car> data;

        public Parking(string type, int capacity)
        {
            this.data = new List<Car>();
            this.Type = type;
            this.Capacity = capacity;
        }

        public int Count
        {
            get { return this.data.Count; }
            
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public void Add(Car car)
        {
            if (this.data.Count<this.Capacity)
            {
                this.data.Add(car);
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            Car curentCar = this.data.Where(x => x.Manufacturer == manufacturer)
                .FirstOrDefault(x => x.Model == model);

            if (curentCar != null)
            {
                this.data.Remove(curentCar);
                return true;
            }
            return false;
        }


        public Car GetLatestCar()
        {
            if (this.data.Count == 0)
            {
                return null;
            }

            else
            {
                Car latestCar = this.data.OrderByDescending(x => x.Year).FirstOrDefault();
                return latestCar;
            }
        }


        public Car GetCar(string manufacturer, string model)
        {
            Car currentCar = this.data.Where(x => x.Manufacturer == manufacturer)
                .FirstOrDefault(x => x.Model == model);

            if (currentCar!=null)
            {
                return currentCar;
            }

            return null;
        }



        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The cars are parked in {this.Type}:");

            foreach (var item in this.data)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString().TrimEnd();
        }

    }
}
