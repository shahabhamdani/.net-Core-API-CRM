using System;
using System.Collections.Generic;

namespace CRM_BackEnd_API.Models
{
    public partial class Company
    {
        public Company()
        {
            Branches = new HashSet<Branches>();
            Department = new HashSet<Department>();
            Employee = new HashSet<Employee>();
            JobInfo = new HashSet<JobInfo>();
            Salary = new HashSet<Salary>();
            UserRoles = new HashSet<UserRoles>();
            Users = new HashSet<Users>();
        }

        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyLogo { get; set; }
        public string Active { get; set; }

        public virtual ICollection<Branches> Branches { get; set; }
        public virtual ICollection<Department> Department { get; set; }
        public virtual ICollection<Employee> Employee { get; set; }
        public virtual ICollection<JobInfo> JobInfo { get; set; }
        public virtual ICollection<Salary> Salary { get; set; }
        public virtual ICollection<UserRoles> UserRoles { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
