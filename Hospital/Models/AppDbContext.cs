using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Hospital.Models
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
            //Database.EnsureDeleted(); 
            Database.EnsureCreated();
            //Database.Migrate();
        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}