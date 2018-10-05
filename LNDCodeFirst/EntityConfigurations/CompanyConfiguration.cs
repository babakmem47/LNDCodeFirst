using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using LNDCodeFirst.Models;

namespace LNDCodeFirst.EntityConfigurations
{
    public class CompanyConfiguration : EntityTypeConfiguration<Company>
    {
        public CompanyConfiguration()
        {
            Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(60);

            Property(p => p.Address)
            .HasMaxLength(200);

            ///////  Company relation ///////////////
            HasMany(c => c.FieldOfActivities)
            .WithMany(f => f.Companies)
            .Map(m =>
            {
                m.ToTable("CompanyFieldOfActivities");
                m.MapLeftKey("CompanyId");
                m.MapRightKey("FieldOfActivityId");
            });
            /////////////////////////////////////////
        }
    }
}