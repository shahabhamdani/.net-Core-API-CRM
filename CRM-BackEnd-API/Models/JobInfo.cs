using System;
using System.Collections.Generic;

namespace CRM_BackEnd_API.Models
{
    public partial class JobInfo
    {
        public int JodInfoId { get; set; }
        public string JoiningDate { get; set; }
        public string Active { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public int? Salary { get; set; }
        public int DepartmentId { get; set; }
        public int DesignationId { get; set; }
        public int EmployeeId { get; set; }
        public string JobType { get; set; }
        public DateTime? EnteredBy { get; set; }
        public DateTime? EnteredOn { get; set; }
        public int BranchId { get; set; }
        public int CompanyId { get; set; }

        public virtual Branches Branch { get; set; }
        public virtual Company Company { get; set; }
        public virtual Department Department { get; set; }
        public virtual Designation Designation { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
