using System;
using System.Collections.Generic;

namespace CRM_BackEnd_API.Models
{
    public partial class Branches
    {
        public Branches()
        {
            Department = new HashSet<Department>();
            Designation = new HashSet<Designation>();
            Employee = new HashSet<Employee>();
            JobInfo = new HashSet<JobInfo>();
            Salary = new HashSet<Salary>();
            UserRoles = new HashSet<UserRoles>();
            Users = new HashSet<Users>();
        }

        public int BranchId { get; set; }
        public string Address { get; set; }
        public int? Type { get; set; }
        public int CompanyId { get; set; }
        public int CityId { get; set; }
        public string BranchName { get; set; }
        public string BranchAddress { get; set; }
        public string BranchEmail { get; set; }
        public string LandLineNumber { get; set; }
        public string CustomerSupport { get; set; }
        public string WhatsappNumber { get; set; }
        public string GeoLocation { get; set; }
        public int CountryId { get; set; }
        public int ProvenceId { get; set; }
        public string Active { get; set; }

        public virtual City City { get; set; }
        public virtual Company Company { get; set; }
        public virtual Country Country { get; set; }
        public virtual Provence Provence { get; set; }
        public virtual ICollection<Department> Department { get; set; }
        public virtual ICollection<Designation> Designation { get; set; }
        public virtual ICollection<Employee> Employee { get; set; }
        public virtual ICollection<JobInfo> JobInfo { get; set; }
        public virtual ICollection<Salary> Salary { get; set; }
        public virtual ICollection<UserRoles> UserRoles { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
