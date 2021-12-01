using System;
using System.Collections.Generic;

namespace CRM_BackEnd_API.Models
{
    public partial class Country
    {
        public Country()
        {
            Branches = new HashSet<Branches>();
            City = new HashSet<City>();
        }

        public int CountryId { get; set; }
        public string CountryName { get; set; }

        public virtual ICollection<Branches> Branches { get; set; }
        public virtual ICollection<City> City { get; set; }
    }
}
