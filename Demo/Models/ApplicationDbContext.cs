using Demo.EntityConfigurations;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Demo.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<IpRange> IpRanges { get; set; }
        public DbSet<Setad> Setads { get; set; }
        public DbSet<Province> Provinces { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new IpRangeConfiguration());
            modelBuilder.Configurations.Add(new SetadConfiguration());
            modelBuilder.Configurations.Add(new ProvinceConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}