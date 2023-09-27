using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessLayer
{
    public partial class Job
    {
        public Job()
        {
            Employees = new HashSet<Employee>();
        }

        public string JobId { get; set; }
        public string JobTotle { get; set; }
        public decimal? MinSalary { get; set; }
        public decimal? MaxSalary { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
