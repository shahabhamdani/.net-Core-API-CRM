using System;
using System.Collections.Generic;

namespace CRM_BackEnd_API.Models
{
    public partial class Users
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserRole { get; set; }
        public string Active { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? EnteredOn { get; set; }
        public int UserRolesId { get; set; }
        public int CompanyId { get; set; }
        public int BranchId { get; set; }

        public virtual Branches Branch { get; set; }
        public virtual Company Company { get; set; }
        public virtual UserRoles UserRoles { get; set; }
    }
}
