
namespace UserService.Database
{
    using Microsoft.EntityFrameworkCore;
    using UserService.Database.Entity;

    public class DatabaseContext:DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=DESKTOP-NL5R8SD\SQLEXPRESS01; initial catalog=Userdb;persist security info=True;user id=sa;password=Rohit@123;");
        }
    }
}
