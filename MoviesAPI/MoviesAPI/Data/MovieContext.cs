using Microsoft.EntityFrameworkCore;
using MoviesAPI.Entities;
namespace MoviesAPI.Data
{
    public class MovieContext(DbContextOptions<MovieContext> options) : DbContext(options)
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }

        //Method to seed data into our database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(
                new Genre { Id = 1, Name = "Action" },
                new Genre { Id = 2, Name = "Sci-Fi" },
                new Genre { Id = 3, Name = "Fantasy" },
                new Genre { Id = 4, Name = "Horror" },
                new Genre { Id = 5, Name = "Romance" }
            );

            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Name = "Inception", Price = 9.99m, GenreId = 1, ReleaseDAte = new DateOnly(2010, 7, 16) },
                new Movie { Id = 2, Name = "The Dark Knight", Price = 8.99m, GenreId = 1, ReleaseDAte = new DateOnly(2008, 7, 18) },
                new Movie { Id = 3, Name = "The Lord of the Rings: The Fellowship of the Ring", Price = 10.99m, GenreId = 3, ReleaseDAte = new DateOnly(2001, 12, 19) },
                new Movie { Id = 4, Name = "The Shining", Price = 7.99m, GenreId = 4, ReleaseDAte = new DateOnly(1980, 5, 23) },
                new Movie { Id = 5, Name = "Titanic", Price = 6.99m, GenreId = 5, ReleaseDAte = new DateOnly(1997, 12, 19) }
            );
        }
    }
}
