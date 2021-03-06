﻿using Demo.Models;
using System.Data.Entity.ModelConfiguration;

namespace Demo.EntityConfigurations
{
    public class SetadConfiguration : EntityTypeConfiguration<Setad>
    {
        public SetadConfiguration()
        {
            HasKey(st => st.Id);

            Property(st => st.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(st => st.Shakhes)
                .HasMaxLength(4).IsFixedLength();

            Property(st => st.IsModiriatShoab)
                .IsOptional();

            Property(st => st.Address)
                .HasMaxLength(200);

            Property(st => st.Email)
                .IsOptional()
                .HasMaxLength(30);

            // Many-to-One with IpRange
            HasRequired(st => st.IpRange)
                .WithMany(ip => ip.Setads)
                .HasForeignKey(st => st.IpRangeId)
                .WillCascadeOnDelete(false);

            // Many-to-(0..1) with Province
            HasOptional(st => st.Province)
                .WithMany(pr => pr.Setads)
                .HasForeignKey(st => st.ProvinceId)
                .WillCascadeOnDelete(false);
        }
    }
}