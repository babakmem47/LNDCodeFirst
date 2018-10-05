using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LNDCodeFirst.Models
{
    public class Company
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string PreTelCode { get; set; }

        public ICollection<FieldOfActivity> FieldOfActivities { get; set; }      // many to many
        
        public ICollection<Person> Persons { get; set; }                         // one to many

    }
}