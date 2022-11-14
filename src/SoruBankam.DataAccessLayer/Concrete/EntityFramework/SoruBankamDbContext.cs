using Microsoft.EntityFrameworkCore;
using SoruBankam.Entities;

namespace SoruBankam.DataAccessLayer.Concrete.EntityFramework
{
    public class SoruBankamDbContext : DbContext
    {
        public DbSet<Question> Questions { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=SoruBankam.db");
            }

            base.OnConfiguring(optionsBuilder);
        }

        public override int SaveChanges()
        {
            var entities = ChangeTracker.Entries<BaseEntity>();

            foreach (var entity in entities)
            {
                if(entity.State == EntityState.Added)
                    entity.Entity.Id = Guid.NewGuid();
            }

            return base.SaveChanges();
        }
    }
}
