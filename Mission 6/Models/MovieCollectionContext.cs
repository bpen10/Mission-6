using Microsoft.EntityFrameworkCore;
using Mission_6.Models;

namespace Mission_6.Models
{
    public class MovieCollectionContext : DbContext
    {
        public MovieCollectionContext(DbContextOptions<MovieCollectionContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}