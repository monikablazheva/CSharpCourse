using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Employee
    {
        private string name;
        private double salary;
        private string position;
        private string category;
        private string email;
        private int age;

        public void ReadData()
        {
            string line = Console.ReadLine();
            List<string> splitLine = line.Split(' ').ToList();
            Name = splitLine[0];
            Salary = double.Parse(splitLine[1]);
            Position = splitLine[2];
            Category = splitLine[3];
            if(splitLine.Count > 4)
            if(splitLine[4].Contains("@"))
            {
                Email = splitLine[4];
                if(splitLine.Count == 6)
                {
                    Age = int.Parse(splitLine[5]);
                }
            }
            else Age = int.Parse(splitLine[4]);
        }

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { this.salary = value; }
        }
        public string Position
        {
            get { return position; }
            set { this.position = value; }
        }
        public string Category
        {
            get { return category; } 
            set { this.category = value; }
        }
        public string Email
        {
            get { return email; } 
            set { this.email = value; }
        }
        public int Age
        {
            get { return age; }
            set { this.age = value; }
        }
    }
}
