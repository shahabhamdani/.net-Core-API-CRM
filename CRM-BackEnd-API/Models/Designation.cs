using System;
using System.Collections.Generic;

namespace CRM_BackEnd_API.Models
{
    public partial class Designation
    {
        public Designation()
        {
            JobInfo = new HashSet<JobInfo>();
        }

        public int DesignationId { get; set; }
        public string DesignationName { get; set; }
        public int BranchId { get; set; }
        public string Active { get; set; }

        public virtual Branches Branch { get; set; }
        public virtual ICollection<JobInfo> JobInfo { get; set; }
    }
}
