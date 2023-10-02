using Microsoft.EntityFrameworkCore;

namespace EntityFramework
{
    public class DatabaseConnection : DbContext
    {
        public DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseInMemoryDatabase(databaseName: "SampleDatabase");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User() { Id = 3, Username = "bhav", Email= "some@gmail.com" }
            );
        }
    }
}
