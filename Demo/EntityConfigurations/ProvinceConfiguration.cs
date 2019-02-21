using Demo.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Demo.EntityConfigurations
{
    public class ProvinceConfiguration : EntityTypeConfiguration<Province>
    {
        public ProvinceConfiguration()
        {
            HasKey(pr => pr.Id);

            Property(pr => pr.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(pr => pr.ProvinceName)
                .IsRequired()
                .HasMaxLength(25);

            Property(pr => pr.CityCenter)
                .IsRequired()
                .HasMaxLength(25);

            Property(pr => pr.PreTelCode)
                .IsOptional()
                .HasMaxLength(4);
        }
    }
}