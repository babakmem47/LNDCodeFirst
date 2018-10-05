using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LNDCodeFirst.Models
{
    public class Person
    {
        
        public int Id { get; set; }
        
        public string Name { get; set; }

        public bool IsKhadamatMashiniPersonnel { get; set; }
        
        public string TelDakheli { get; set; }
        
        public string TelMostaghim { get; set; }
        
        public string Mobile { get; set; }

        public string Email { get; set; }

        public Province Province { get; set; }

        public int? ProvinceId { get; set; }

        public Semat Semat { get; set; }

        public int? SematId { get; set; }

        public Company Company { get; set; }

        public int? CompanyId { get; set; }
        
    }
}