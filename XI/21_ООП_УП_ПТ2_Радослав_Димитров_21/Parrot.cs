using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_ООП_УП_ПТ2_Радослав_Димитров_21
{
    class Parrot: Animal, IAnimalWorld
    {
        private double energy;
        public double Energy
        {
            get { return this.energy; }
            set { this.energy = value; }
        }
        public Parrot(string name, string favouriteFood, string area, double energy)
        {
            this.name = name;
            this.favouriteFood = favouriteFood;
            this.area = area;
            this.energy = energy;
        }
        public void Sleep(double energy)
        {
            Console.WriteLine("Sleeping for how long (hours): ");
            double hoursOfSleep = double.Parse(Console.ReadLine());
            this.energy += 2 * hoursOfSleep;
            Console.Write("Energy restored: ");
            Console.Write(this.energy - energy);
        }
        public void Move()
        {
            if (this.energy >= 5)
            {
                Console.WriteLine("Starting to move.");
                Console.WriteLine("New Destination:");
                this.area = Console.ReadLine();
                this.energy -= 5;
            }
            else
            {
                Console.WriteLine("No energy. Sleeping... (You need {0} hours of sleep to have enough energy for the move)", 5 - this.energy);
                Sleep(this.energy);
                Console.Write(" Energy: ");
                Console.Write(this.energy);
                Console.WriteLine(" Continuing to move.");
                Move();
            }
        }
        public override string ExplainMyself()
        {
            string a = base.ExplainMyself();
            a = "I am " + this.name + " and my favourite food is " + this.favouriteFood + " and my area is " + this.area + ".";
            return a;
        }
        

    }
}
