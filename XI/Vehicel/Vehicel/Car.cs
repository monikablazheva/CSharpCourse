using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicel
{
    class Car : Vehicel
    {
        protected short wheelsCount;
        public short WheelsCount
        {
            get { return this.wheelsCount; }
            set { this.wheelsCount = value; }
        }
        public Car()
        {
            this.wheelsCount = 4;
            this.passangersCount = 5;
        }
        public Car(short passangerCount)
        {
            this.wheelsCount = 4;
            this.passangersCount = passangerCount;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("It has {0} wheels", this.wheelsCount);
        }
        public override void Tunning(int additionalSpeed)
        {
            base.Tunning(additionalSpeed);
            Console.WriteLine("Enter new model wheels:");
            string wheelsModel = Console.ReadLine();
            Console.WriteLine("New {0} wheels model were added.", wheelsModel);
        }
    }
}
