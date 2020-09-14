using Microsoft.EntityFrameworkCore;

namespace Penske.Mobilep.Data.ModelsCreating
{
    public static class ModelCreatingInventoryStatus
    {
        public static void Creating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InventoryStatus>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NameStatus)
                    .IsRequired()
                    .HasMaxLength(20);
            });

        }
    }
}
