using Microsoft.EntityFrameworkCore;

namespace Penske.Mobilep.Data.ModelsCreating
{
    public static class ModelCreatingNotifications
    {
        public static void Creating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Notifications>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(80);
            });

        }
    }
}
