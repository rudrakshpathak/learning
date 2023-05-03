using ASP_WebAPI.Entity_Framework;
using Microsoft.EntityFrameworkCore;

namespace ASP_WebAPI
{
    public class DatabaseConnection : DbContext
    {
        public DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseMySQL("Server=localhost;Database=userdb;Uid=root;Pwd=;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User() { Id = 3, Username = "bhav", Email= "some@gmail.com" }
            );
        }
    }
}
