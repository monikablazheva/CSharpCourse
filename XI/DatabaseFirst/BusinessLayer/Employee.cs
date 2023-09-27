using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessLayer
{
    public partial class Employee
    {
        public Employee()
        {
            Departments = new HashSet<Department>();
            InverseManager = new HashSet<Employee>();
            Orders = new HashSet<Order>();
        }

        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public decimal Salary { get; set; }
        public string JobId { get; set; }
        public int? ManagerId { get; set; }
        public int? DepartmentId { get; set; }

        public virtual Department Department { get; set; }
        public virtual Job Job { get; set; }
        public virtual Employee Manager { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
        public virtual ICollection<Employee> InverseManager { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
