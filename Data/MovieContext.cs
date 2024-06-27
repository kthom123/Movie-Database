using Microsoft.EntityFrameworkCore;
using Movie_Database.Models;

namespace Movie_Database.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
