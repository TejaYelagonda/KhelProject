using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Models
{
    public partial class Area
    {
        public int AreaId { get; set; }
        public string AreaName { get; set; }
        public int CityId { get; set; }
        public int Pincode { get; set; }

        public virtual City City { get; set; }
    }
}
