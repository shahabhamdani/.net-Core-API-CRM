using System;
using System.Collections.Generic;

namespace CRM_BackEnd_API.Models
{
    public partial class UserRoles
    {
        public UserRoles()
        {
            Users = new HashSet<Users>();
        }

        public int UserRolesId { get; set; }
        public string UserRole { get; set; }
        public int BranchId { get; set; }
        public string Active { get; set; }
        public int CompanyId { get; set; }

        public virtual Branches Branch { get; set; }
        public virtual Company Company { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
