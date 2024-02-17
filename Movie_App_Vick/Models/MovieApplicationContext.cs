using Microsoft.EntityFrameworkCore;

namespace Movie_App_Vick.Models
{
    public class MovieApplicationContext : DbContext
    {
        public MovieApplicationContext(DbContextOptions<MovieApplicationContext> options) : base (options)
        {
        }

        public DbSet<Application> Applications { get; set; }
    }
}
