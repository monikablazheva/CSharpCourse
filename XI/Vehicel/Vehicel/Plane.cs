using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicel
{
    class Plane : Vehicel
    {
        protected string wingSystem;
        protected string material;
        public string WingSystem
        {
            get { return this.wingSystem; }
            set { this.wingSystem = value; }
        }
        public string Material
        {
            get { return this.material; }
            set { this.material = value; }
        }
        public Plane()
        {
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("The plane is made of {0} material and has {1} wing system.", this.material, this.wingSystem);
        }
    }
}
