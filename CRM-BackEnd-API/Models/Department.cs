using System;
using System.Collections.Generic;

namespace CRM_BackEnd_API.Models
{
    public partial class Department
    {
        public Department()
        {
            JobInfo = new HashSet<JobInfo>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string Description { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? EnteredOn { get; set; }
        public int BranchId { get; set; }
        public string Active { get; set; }
        public int CompanyId { get; set; }

        public virtual Branches Branch { get; set; }
        public virtual Company Company { get; set; }
        public virtual ICollection<JobInfo> JobInfo { get; set; }
    }
}
