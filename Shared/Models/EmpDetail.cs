using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Models
{
    public partial class EmpDetail
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public int? Salary { get; set; }
        public int? Age { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
    }
}
