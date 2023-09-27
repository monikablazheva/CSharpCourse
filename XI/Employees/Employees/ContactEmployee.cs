using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class ContactEmployee : BaseEmployee
    {
        private string employeeTask;
        private string employeeDepartment;
        public string EmployeeId
        {
            get { return this.employeeID; }
            set { this.employeeID = value; }
        }
        public string EmployeeName
        {
            get { return this.employeeName; }
            set { this.employeeName = value; }
        }
        public string Address
        {
            get { return this.employeeAddress; }
            set { this.employeeAddress = value; }
        }
        public ContactEmployee(string id, string name, string address, string task, string department) : base(id, name, address)
        {
            this.employeeTask = task;
            this.employeeDepartment = department;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Employee task: " + employeeTask);
            Console.WriteLine("Department: " + employeeDepartment);
        }

        public override double CalculateSalary(int workingHours)
        {
            return 250 + workingHours * 20;
        }

        public override string GetDepartment()
        {
            return this.employeeDepartment;
        }
    }
}
