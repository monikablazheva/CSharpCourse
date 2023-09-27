using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Pharmacy
{
    class Pharmacy
    {
        private string name;
        private List<Medicine> listOfMedicine;

        public Pharmacy(string name)
        {
            this.Name = name;
            this.ListOfMedicine = new List<Medicine>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {

                if ((this.name.Length < 3) && (System.Text.RegularExpressions.Regex.IsMatch(this.name, @"^[a-zA-Z0-9\_]+$"))) throw new ArgumentException("Invalid name");
                this.name = value;
            }
        }
        public List<Medicine> ListOfMedicine
        {
            get
            {
                return this.listOfMedicine;
            }
            set
            {
                this.listOfMedicine = value;
            }
        }

        ///validation
        ///



        public void Order(Medicine medicine)
        {
            listOfMedicine.Add(medicine);
        }

        public bool Sell(Medicine medicine)
        {
            if (listOfMedicine.Contains(medicine))
            {
                listOfMedicine.Remove(medicine);
                return true;
            }
            return false;
        }

        public double CalculateTotalPrice()
        {
            double sum = 0;
            foreach (var medicine in listOfMedicine)
            {
                sum += medicine.Price;
            }
            return sum;
        }

        public void RenamePharmacy(string name)
        {
            this.Name = name;
        }

        public void SellAllMedicines()
        {
            listOfMedicine.Clear();
        }

        public Medicine GetMedicineWithHighestPrice()
        {
            double highestPrice = 0;
            int answer = 0, circuit = 0;
            foreach (var medicine in listOfMedicine)
            {
                if (medicine.Price > highestPrice)
                {
                    highestPrice = medicine.Price;
                    answer = circuit;
                }
                circuit++;
            }
            return listOfMedicine[answer];
            //foreach (var medicine in listOfMedicine)
            //{
            //  if (medicine.Price == highestPrice)
            //{
            //  return medicine;
            //}
            //}
            //throw new ArgumentException("Something went wrong.");
        }

        public Medicine GetMedicineWithLowestPrice()
        {
            double lowestPrice = double.MaxValue;
            int answer = 0, circuit = 0;
            foreach (var medicine in listOfMedicine)
            {
                if (medicine.Price < lowestPrice)
                {
                    lowestPrice = medicine.Price;
                    answer = circuit;
                }
                circuit++;
            }
            return listOfMedicine[answer];
            //foreach (var medicine in listOfMedicine)
            //{
            //  if (medicine.Price == lowestPrice)
            //{
            //  return medicine;
            //}
            //}
            //throw new ArgumentException("Something went wrong.");
        }
        public override string ToString()
        {
            string result = "Pharmacy " + this.Name + " has " + this.listOfMedicine.Count + " medicines and they are:\n";
            if (this.listOfMedicine.Count == 0)
                result += "N/A";
            foreach (var item in this.listOfMedicine)
            {
                result += item;
            }
            return result;
        }
    }
}
