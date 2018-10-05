using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LNDCodeFirst.Models
{
    public class Semat
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Person> Persons { get; set; }
    }
}