using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using LNDCodeFirst.Models;

namespace LNDCodeFirst.EntityConfigurations
{
    public class ProvinceConfiguration : EntityTypeConfiguration<Province>
    {
        public ProvinceConfiguration()
        {
            Property(p => p.Shakhes)
            .IsRequired();
            
            Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(50);
            
            Property(p => p.CityCenter)
            .HasMaxLength(25);
            
            Property(p => p.Address)
            .HasMaxLength(200);
            
            Property(p => p.Email)
            .HasMaxLength(30);
            
            Property(p => p.PreTelCode)
            .HasMaxLength(4);
        }
    }
}