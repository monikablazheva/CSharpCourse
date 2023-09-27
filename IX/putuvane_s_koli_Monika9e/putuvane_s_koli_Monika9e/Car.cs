using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace putuvane_s_koli_Monika9e
{
    class Car
    {
        public string model;
        public double kolichestvoGorivo;
        public double razhod1km;
        public double izminatiKm = 0;

        public void CheckTheNeededFuel()
        {
            double nujnoGorivo = izminatiKm * razhod1km;
            double ostatuk;
            if (nujnoGorivo <= kolichestvoGorivo)
            {
                ostatuk = kolichestvoGorivo - nujnoGorivo;
                Console.WriteLine("Model: {0}, Nalichno gorivo: {1:f2}, Proputuvani km: {2:f2}", model, ostatuk, izminatiKm);
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the {0} drive", model);
            }
        }
        public string Model
        {
            get { return model; }
            set { this.model = value; }
        }
        public double KolichestvoGorivo
        {
            get { return kolichestvoGorivo; }
            set { this.kolichestvoGorivo = value; }
        }
        public double Razhod1km
        {
            get { return razhod1km; }
            set { this.razhod1km = value; }
        }
        public double IzminatiKm
        {
            get { return izminatiKm; } 
            set { this.izminatiKm = value; }
        }
    }
}
