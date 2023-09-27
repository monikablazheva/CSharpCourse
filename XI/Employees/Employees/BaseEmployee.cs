using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    abstract class BaseEmployee
    {
        protected string employeeID;
        protected string employeeName;
        protected string employeeAddress;
        public BaseEmployee(string id, string name, string address)
        {
            this.employeeID = id;
            this.employeeName = name;
            this.employeeAddress = address;
        }
        public virtual void Show()
        {
            Console.WriteLine("Employee ID: " + employeeID);
            Console.WriteLine("Name: " + employeeName);
            Console.WriteLine("Address: " + employeeAddress);
        }
        public abstract double CalculateSalary(int workingHours);
        public abstract string GetDepartment();
    }
}
