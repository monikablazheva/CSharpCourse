using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicel
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicel vehicel = new Vehicel();
            Console.WriteLine("Enter the model:");
            vehicel.Model = Console.ReadLine();
            Console.WriteLine("Enter the speed");
            vehicel.Speed = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the color");
            vehicel.Color = Console.ReadLine();
            Console.WriteLine("Enter the additional speed:");
            int additionalSpeed = int.Parse(Console.ReadLine());
            vehicel.ShowInfo();
            vehicel.Tunning(additionalSpeed);

            Console.WriteLine("Enter the car's passangers capacity:");
            short passangersCount = short.Parse(Console.ReadLine());
            Car car = new Car(passangersCount);
            //Car car = new Car();
            Console.WriteLine("Enter the model:");
            car.Model = Console.ReadLine();
            Console.WriteLine("Enter the speed");
            car.Speed = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the color");
            car.Color = Console.ReadLine();
            Console.WriteLine("Enter the additional speed:");
            int additionalSpeedForCar = int.Parse(Console.ReadLine());
            car.ShowInfo();
            car.Tunning(additionalSpeedForCar);

            Plane plane = new Plane();
            plane.Speed = 840;
            plane.Model = "Dufenshmertz3000";
            plane.Color = "white";
            plane.Material = "aluminium";
            plane.WingSystem = "Butterfly2.5";
            plane.PassangersCount = 100;
            plane.ShowInfo();
        }
    }
}
