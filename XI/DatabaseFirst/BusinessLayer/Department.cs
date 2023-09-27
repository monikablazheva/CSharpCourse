using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessLayer
{
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int? ManagerId { get; set; }
        public string CountryId { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Adress { get; set; }
        public string PostalCode { get; set; }

        public virtual Country Country { get; set; }
        public virtual Employee Manager { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
