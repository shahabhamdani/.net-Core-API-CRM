using System;
using System.Collections.Generic;

namespace CRM_BackEnd_API.Models
{
    public partial class Provence
    {
        public Provence()
        {
            Branches = new HashSet<Branches>();
            City = new HashSet<City>();
        }

        public int ProvenceId { get; set; }
        public string ProvenceName { get; set; }

        public virtual ICollection<Branches> Branches { get; set; }
        public virtual ICollection<City> City { get; set; }
    }
}
