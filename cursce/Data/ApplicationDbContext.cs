using cursce.Models;
using Microsoft.EntityFrameworkCore;

namespace cursce.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Курт", Surname = "Кобейн", CauseOfDeath = "Застрелился на смерть ха-ха", IsLegend = true},
                new Category { Id = 2, Name = "Хит", Surname = "Леджер", CauseOfDeath = "Передозик", IsLegend = true },
                new Category { Id = 3, Name = "Джон", Surname = "Кенеди", CauseOfDeath = "Застрелили за то что пиздел много", IsLegend = true }
                );

        }

    }
}
