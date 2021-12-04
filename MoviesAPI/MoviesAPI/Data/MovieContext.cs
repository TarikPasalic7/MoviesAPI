using Microsoft.EntityFrameworkCore;
using MoviesAPI.Models;

namespace MoviesAPI.Data
{
    
   
        public class MovieContext : DbContext
        {
            public MovieContext(DbContextOptions<MovieContext> options)
                : base(options)
            {
            }

            public DbSet<Actor> Actor  { get; set; } = null!;
            public DbSet<Director> Director { get; set; } = null!;
            public DbSet<Genre> Genre { get; set; } = null!;
            public DbSet<Movie> Movie { get; set; } = null!;
            public DbSet<MovieActor> MovieActor { get; set; } = null!;
            public DbSet<MovieGenre> MovieGenre { get; set; } = null!;
        }
    
}
