using Microsoft.EntityFrameworkCore;

namespace Penske.Mobilep.Data.ModelsCreating
{
    public static class ModelCreatingUnits
    {
        public static void Creating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Units>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Unit).HasMaxLength(50);
            });

        }
    }
}
