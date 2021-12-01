using System;
using System.Collections.Generic;

namespace CRM_BackEnd_API.Models
{
    public partial class Salary
    {
        public int SalaryId { get; set; }
        public int? BasicSalary { get; set; }
        public int? Allowance { get; set; }
        public int? Tax { get; set; }
        public int? GrossSalary { get; set; }
        public int? NetSalary { get; set; }
        public int BranchId { get; set; }
        public string Active { get; set; }
        public int CompanyId { get; set; }

        public virtual Branches Branch { get; set; }
        public virtual Company Company { get; set; }
    }
}
