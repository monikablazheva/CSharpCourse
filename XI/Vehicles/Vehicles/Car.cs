using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Car : Vehicle
    {
        private double fuelQuantity;
        private double litersPerKm;
        double Vehicle.FuelQuantity
        {
            get { return this.fuelQuantity; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Liters per km should be non-negative number.");
                }
                this.fuelQuantity = value; 
            }
        }
        double Vehicle.LitersPerKm
        {
            get { return this.litersPerKm; }
            set 
            { 
                if(value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Liters per km should be positive number.");
                }
                this.litersPerKm = value; 
            }
        }
        public Car(double f, double l)
        {
            this.fuelQuantity = f;
            this.litersPerKm = l;
        }
        public void Drive(double distance, string season)
        {
            if(season.ToLower() == "summer")
            {
                litersPerKm += 0.9;
            }
            double newDistance = fuelQuantity / litersPerKm;
            if (newDistance >= distance)
            {
                Console.WriteLine("Car travelled {0:f2}km with {1:f2}liters fuel.", distance, distance * litersPerKm);
                fuelQuantity -= distance * litersPerKm;
                Console.WriteLine("Car fuel left: {0:f2}", fuelQuantity);
            }
            else
            {
                Console.WriteLine("Car needs refueling of {0:f2}liters", (distance * litersPerKm) - fuelQuantity);
                Console.WriteLine("Car fuel left: {0:f2}", fuelQuantity);
            }
        }
        public void Refuel(double newFuel)
        {
            fuelQuantity += newFuel;
            Console.WriteLine("Car refueled with {0:f2}liters. New car fuel quantity is {1:f2}liters.", newFuel, fuelQuantity);
        }
    }
}
