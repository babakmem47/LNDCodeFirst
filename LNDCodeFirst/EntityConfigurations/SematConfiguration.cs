using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using LNDCodeFirst.Models;

namespace LNDCodeFirst.EntityConfigurations
{
    public class SematConfiguration : EntityTypeConfiguration<Semat>
    {
        public SematConfiguration()
        {
            Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(50);
        }
    }
}