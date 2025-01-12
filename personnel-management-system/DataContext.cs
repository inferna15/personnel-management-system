using Microsoft.EntityFrameworkCore;

namespace personnel_management_system
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Personnel> Personnels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=AppDatabase.db");
        }
    }
}
