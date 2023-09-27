using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    interface Vehicle
    {
        double FuelQuantity 
        {
            get;
            set;
        }
        double LitersPerKm
        {
            get;
            set;
        }
        void Drive(double distance, string season);
        void Refuel(double fuel);
        
    }
}
