using Microsoft.EntityFrameworkCore;

namespace Penske.Mobilep.Data.ModelsCreating
{
    public static class ModelCreatingInventory
    {
        public static void Creating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Control).HasMaxLength(20);

                entity.Property(e => e.Cyc).HasColumnName("CYC");

                entity.Property(e => e.Location).HasMaxLength(10);

                entity.Property(e => e.Model).HasMaxLength(20);

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.Property(e => e.Vin)
                    .HasColumnName("VIN")
                    .HasMaxLength(25);
            });
        }
    }
}
