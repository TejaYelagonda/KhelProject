using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccessLayer.Models
{
    public partial class Student
    {
        public int StdId { get; set; }
        public string StdName { get; set; }
        public int? StdAge { get; set; }
        public string StdGender { get; set; }
        public int? StdClass { get; set; }
    }
}
