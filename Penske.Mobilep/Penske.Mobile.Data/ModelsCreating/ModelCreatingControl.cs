using Microsoft.EntityFrameworkCore;

namespace Penske.Mobilep.Data.ModelsCreating
{
    public static class ModelCreatingControl
    {
        public static void Creating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Control>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Safety).HasDefaultValueSql("((0))");
            });
        }
    }
}
