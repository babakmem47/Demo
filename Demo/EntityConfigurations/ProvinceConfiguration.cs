using Demo.Models;
using System.Data.Entity.ModelConfiguration;

namespace Demo.EntityConfigurations
{
    public class ProvinceConfiguration : EntityTypeConfiguration<Province>
    {
        public ProvinceConfiguration()
        {
            Property(pr => pr.ProvinceName)
                .IsRequired()
                .HasMaxLength(25);

            Property(pr => pr.Octet3)
                .IsOptional();

            Property(pr => pr.CityCenter)
                .IsRequired()
                .HasMaxLength(25);

            Property(pr => pr.PreTelCode)
                .IsOptional()
                .HasMaxLength(4);

            // One-To-(0..1) with Setad                             // Do not define this(Definition in Setad 
            //HasOptional(pr => pr.Setad)                           // is enough!) 
            //    .WithOptionalPrincipal(st => st.Province);
        }
    }
}