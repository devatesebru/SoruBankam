using Microsoft.EntityFrameworkCore;
using SoruBankam.Entities;

namespace SoruBankam.DataAccessLayer.Concrete.EntityFramework
{
    public class SoruBankamDbContext : DbContext
    {
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=SoruBankam.db");
            }

            base.OnConfiguring(optionsBuilder);
        }
    }
}
