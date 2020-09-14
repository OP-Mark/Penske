using Microsoft.EntityFrameworkCore;

namespace Penske.Mobilep.Data.ModelsCreating
{
    public static class ModelCreatingForkliftGoal
    {
        public static void Creating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ForkliftGoal>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");
            });

        }
    }
}
