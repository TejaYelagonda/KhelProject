using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Models
{
    public partial class City
    {
        public City()
        {
            Areas = new HashSet<Area>();
        }

        public int CityId { get; set; }
        public string CityName { get; set; }

        public virtual ICollection<Area> Areas { get; set; }
    }
}
