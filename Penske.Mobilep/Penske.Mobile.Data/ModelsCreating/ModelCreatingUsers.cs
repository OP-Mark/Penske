using Microsoft.EntityFrameworkCore;

namespace Penske.Mobilep.Data.ModelsCreating
{
    public static class ModelCreatingUsers
    {
        public static void Creating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(80)
                    .IsFixedLength();

                entity.Property(e => e.Email).HasField("_email");

                entity.Property(e => e.FullName)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Password)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Perfil).HasDefaultValueSql("((1))");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.HasQueryFilter(e => e.Active == true);
            });
        }
    }
}
