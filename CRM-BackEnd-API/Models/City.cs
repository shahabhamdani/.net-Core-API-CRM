using System;
using System.Collections.Generic;

namespace CRM_BackEnd_API.Models
{
    public partial class City
    {
        public City()
        {
            Branches = new HashSet<Branches>();
        }

        public int CityId { get; set; }
        public string CityName { get; set; }
        public int ProvenceId { get; set; }
        public int CountryId { get; set; }
        public string CityShortName { get; set; }
        public string Active { get; set; }

        public virtual Country Country { get; set; }
        public virtual Provence Provence { get; set; }
        public virtual ICollection<Branches> Branches { get; set; }
    }
}
