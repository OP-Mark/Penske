using Microsoft.EntityFrameworkCore;
using Penske.Mobilep.Data.ModelsCreating;

namespace Penske.Mobilep.Data
{
    public partial class PenskeMobileContext : DbContext
    {
        public PenskeMobileContext()
        {
        }

        public PenskeMobileContext(DbContextOptions<PenskeMobileContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Control> Control { get; set; }
        public virtual DbSet<ForkliftGoal> ForkliftGoal { get; set; }
        public virtual DbSet<ForkliftUtilization> ForkliftUtilization { get; set; }
        public virtual DbSet<Inspection> Inspection { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<InventoryStatus> InventoryStatus { get; set; }
        public virtual DbSet<LocationsConfiguration> LocationsConfiguration { get; set; }
        public virtual DbSet<LogBitacora> LogBitacora { get; set; }
        public virtual DbSet<Models> Models { get; set; }
        public virtual DbSet<Notifications> Notifications { get; set; }
        public virtual DbSet<Safety> Safety { get; set; }
        public virtual DbSet<Units> Units { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-RT6MQC1; Initial Catalog=PenskeMobile; Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ModelCreatingControl.Creating(modelBuilder);

            ModelCreatingForkliftGoal.Creating(modelBuilder);

            ModelCreatingInspection.Creating(modelBuilder);

            ModelCreatingInventory.Creating(modelBuilder);

            ModelCreatingInventoryStatus.Creating(modelBuilder);

            ModelCreatingLocationsConfiguration.Creating(modelBuilder);

            ModelCreatingLogBitacora.Creating(modelBuilder);

            ModelCreatingModels.Creating(modelBuilder);
            
            ModelCreatingNotifications.Creating(modelBuilder);
            
            ModelCreatingSafety.Creating(modelBuilder);
            
            ModelCreatingUnits.Creating(modelBuilder);

            ModelCreatingUsers.Creating(modelBuilder);


            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
