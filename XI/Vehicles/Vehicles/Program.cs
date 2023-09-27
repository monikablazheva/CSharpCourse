using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuelQuantity = Console.ReadLine();
            string litersPerKm = Console.ReadLine();
            try { double.Parse(fuelQuantity);}
            catch(FormatException) { Console.WriteLine("Fuel quantity should be a number."); }
            try { double.Parse(litersPerKm); }
            catch(FormatException) { Console.WriteLine("Liters per km should be a number."); }
            Car myCar = new Car(double.Parse(fuelQuantity), double.Parse(litersPerKm));

            
            string distance = Console.ReadLine();
            string season = Console.ReadLine();
            try { double.Parse(distance); }
            catch (FormatException) { Console.WriteLine("Distance should be a number."); }
            myCar.Drive(double.Parse(distance), season);

            string newFuel = Console.ReadLine();
            try { double.Parse(newFuel); }
            catch (FormatException) { Console.WriteLine("New fuel should be a number."); }
            myCar.Refuel(double.Parse(newFuel));
        }
    }
}
