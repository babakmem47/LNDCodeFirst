using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using LNDCodeFirst.Models;

namespace LNDCodeFirst.EntityConfigurations
{
    public class FieldOfActivityConfiguration : EntityTypeConfiguration<FieldOfActivity>
    {
        public FieldOfActivityConfiguration()
        {
            Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(70);

        }
    }
}