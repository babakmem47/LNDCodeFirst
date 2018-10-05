using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LNDCodeFirst.Models;

namespace LNDCodeFirst.Dtos
{
    public class ProvinceDto
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public int Shakhes { get; set; }

        public string CityCenter { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string PreTelCode { get; set; }

    }
}