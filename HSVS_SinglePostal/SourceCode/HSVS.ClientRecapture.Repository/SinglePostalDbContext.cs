using HSVS.SinglePostal.Data;
using System.Configuration;
using System.Data.Entity;

namespace HSVS.SinglePostal.Repository
{
    public partial class SinglePostalDbContext : DbContext
    {
        public SinglePostalDbContext()
        {
            Database.Connection.ConnectionString = ConfigurationManager.ConnectionStrings["SinglePostalDbContext"].ConnectionString;
            Configuration.AutoDetectChangesEnabled = false;
        }

        public DbSet<DefaultPostalSettings> DefaultPostalSettings { get; set; }
        public DbSet<HospitalPostalSettings> HospitalPostalSettings { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<RapportMapping> RapportMappings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {           
            Database.SetInitializer<SinglePostalDbContext>(null);
            modelBuilder.Entity<DefaultPostalSettings>().ToTable("crecap_default_postal_settings", "campaign");
            modelBuilder.Entity<HospitalPostalSettings>().ToTable("crecap_hospital_postal_settings", "campaign");
            modelBuilder.Entity<Hospital>().ToTable("hospital", "public");
            modelBuilder.Entity<RapportMapping>().ToTable("crecap_rapport_vs_mapping", "campaign");
        }
    }
}
