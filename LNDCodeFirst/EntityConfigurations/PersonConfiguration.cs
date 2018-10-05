using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using LNDCodeFirst.Models;

namespace LNDCodeFirst.EntityConfigurations
{
    public class PersonConfiguration : EntityTypeConfiguration<Person>
    {

        public PersonConfiguration()
        {

            /////// Table overwrite //////////////
            ToTable("Persons");
            ///////////////////////////////////////
            

            /////// Primary Keys Overwrite ////////
            HasKey(p => p.Id);
            ///////////////////////////////////////


            /////// Property Configurations ///////
            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50);


            Property(p => p.TelDakheli)
                .HasMaxLength(30);


            Property(p => p.TelMostaghim)
                .HasMaxLength(50);


            Property(p => p.Mobile)
                .HasMaxLength(11)
                .IsFixedLength();
            ///////////////////////////////////////


            /////// Person relations //////////////
            HasOptional(p => p.Province)
                .WithMany(p => p.Persons)
                .HasForeignKey(p => p.ProvinceId)
                .WillCascadeOnDelete(false);


            HasOptional(p => p.Semat)
                .WithMany(p => p.Persons)
                .HasForeignKey(p => p.SematId)
                .WillCascadeOnDelete(false);


            HasOptional(p => p.Company)
                .WithMany(p => p.Persons)
                .HasForeignKey(p => p.CompanyId)
                .WillCascadeOnDelete(false);
            ///////////////////////////////////////

        }

    }
}