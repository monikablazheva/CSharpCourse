using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicel
{
    class Vehicel
    {
        protected int speed;
        protected string model;
        protected string color;
        protected short passangersCount;
        public short PassangersCount
        {
            get { return this.passangersCount; }
            set { this.passangersCount = value; }
        }
        public int Speed
        {
            get { return this.speed; }
            set { this.speed = value; }
        }
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }
        public Vehicel()
        {
        }
        public Vehicel(int speed, string model, string color)
        {
            this.speed = speed;
            this.model = model;
            this.color = color;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine("The vehicel is {0} model in {1} color with {2}km/h speed and has {3} passangers capacity.", this.model, this.color, this.speed, this.passangersCount);
        }
        public virtual void Tunning(int additionalSpeed)
        {
            this.speed += additionalSpeed;
            this.model += "tunned";
            Console.WriteLine("The {0} model was tunned with additional {1}km/h. New max speed is {2}km/h.", this.model, additionalSpeed, (this.speed + additionalSpeed));
        }

    }
}
