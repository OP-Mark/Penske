using Microsoft.EntityFrameworkCore;

namespace Penske.Mobilep.Data.ModelsCreating
{
    public static class ModelCreatingSafety
    {
        public static void Creating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Safety>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Carrier).HasMaxLength(50);

                entity.Property(e => e.Control).HasMaxLength(20);

                entity.Property(e => e.CurtainFullyOpen).HasDefaultValueSql("((0))");

                entity.Property(e => e.DockNum).HasMaxLength(4);

                entity.Property(e => e.EndTime).HasMaxLength(10);

                entity.Property(e => e.LoadId)
                    .HasColumnName("LoadID")
                    .HasMaxLength(10);

                entity.Property(e => e.LoadType).HasMaxLength(10);

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");

                entity.Property(e => e.StartTime).HasMaxLength(10);

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.Property(e => e.Trailer).HasMaxLength(10);

                entity.Property(e => e.TrailerLock).HasDefaultValueSql("((0))");

                entity.Property(e => e.WeelChocked).HasDefaultValueSql("((0))");
            });

        }
    }
}
