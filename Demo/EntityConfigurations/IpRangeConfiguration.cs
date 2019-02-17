using Demo.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace Demo.EntityConfigurations
{
    public class IpRangeConfiguration : EntityTypeConfiguration<IpRange>
    {
        public IpRangeConfiguration()
        {
            HasKey(ip => ip.Id);

            Property(ip => ip.Range)
                .IsRequired()
                .HasMaxLength(15)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute { IsUnique = true })
                );

            Property(ip => ip.Mask)
                .IsRequired()
                .HasMaxLength(2).IsFixedLength();

            // One-to-Many with Setad
            HasMany(ip => ip.Setads)
                .WithRequired(st => st.IpRange);
        }
    }
}