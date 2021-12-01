using System;
using System.Collections.Generic;

namespace CRM_BackEnd_API.Models
{
    public partial class Employee
    {
        public Employee()
        {
            JobInfo = new HashSet<JobInfo>();
        }

        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int CompanyId { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? EnteredOn { get; set; }
        public string Address { get; set; }
        public int BranchId { get; set; }
        public string GuardianRelation { get; set; }
        public string GuardianName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string MobileNumber { get; set; }
        public string Cnicnumber { get; set; }
        public string EmployeeImage { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeNtn { get; set; }
        public string BankAccountNumber { get; set; }
        public string BankAccountTitle { get; set; }
        public string BankName { get; set; }
        public string Active { get; set; }

        public virtual Branches Branch { get; set; }
        public virtual Company Company { get; set; }
        public virtual ICollection<JobInfo> JobInfo { get; set; }
    }
}
