using Microsoft.EntityFrameworkCore;
using Mission_6.Models;

namespace Mission_6.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MovieCollectionContext(
                serviceProvider.GetRequiredService<DbContextOptions<MovieCollectionContext>>()))
            {
                // Look for any movies
                if (context.Movies.Any())
                {
                    return; // DB has been seeded
                }

                context.Movies.AddRange(
                    new Movie
                    {
                        Category = "Sci-Fi",
                        Title = "The Matrix",
                        Year = 1999,
                        Director = "Lana and Lilly Wachowski",
                        Rating = "R",
                        Edited = false,
                        LentTo = "",
                        Notes = "Classic sci-fi film"
                    },

                    new Movie
                    {
                        Category = "Comedy",
                        Title = "The Princess Bride",
                        Year = 1987,
                        Director = "Rob Reiner",
                        Rating = "PG",
                        Edited = false,
                        LentTo = "",
                        Notes = "Funny and heartwarming"
                    },

                    new Movie
                    {
                        Category = "Drama",
                        Title = "The Shawshank Redemption",
                        Year = 1994,
                        Director = "Frank Darabont",
                        Rating = "R",
                        Edited = true,
                        LentTo = "",
                        Notes = "Based on Stephen King"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}