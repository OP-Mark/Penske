using Microsoft.EntityFrameworkCore;

namespace Penske.Mobilep.Data.ModelsCreating
{
    public static class ModelCreatingModels
    {
        public static void Creating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comments).HasMaxLength(250);

                entity.Property(e => e.Model)
                    .HasColumnName("MODEL")
                    .HasMaxLength(15);
            });

        }
    }
}
