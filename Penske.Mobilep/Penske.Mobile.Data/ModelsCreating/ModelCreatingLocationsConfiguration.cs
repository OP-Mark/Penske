using Microsoft.EntityFrameworkCore;

namespace Penske.Mobilep.Data.ModelsCreating
{
    public static class ModelCreatingLocationsConfiguration
    {
        public static void Creating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LocationsConfiguration>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Location).HasMaxLength(10);

                entity.Property(e => e.Models).HasMaxLength(250);

                entity.Property(e => e.ModelsPriorityI).HasMaxLength(250);

                entity.Property(e => e.ModelsPriorityR).HasMaxLength(250);

                entity.Property(e => e.Nvins).HasColumnName("NVins");

                entity.Property(e => e.Rrow).HasMaxLength(10);
            });

        }
    }
}
