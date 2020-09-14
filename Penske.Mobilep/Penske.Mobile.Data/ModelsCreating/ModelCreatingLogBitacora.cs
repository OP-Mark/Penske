using Microsoft.EntityFrameworkCore;

namespace Penske.Mobilep.Data.ModelsCreating
{
    public static class ModelCreatingLogBitacora
    {
        public static void Creating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LogBitacora>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Control).HasMaxLength(20);

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.Property(e => e.Vin)
                    .HasColumnName("VIN")
                    .HasMaxLength(20);
            });

        }
    }
}
