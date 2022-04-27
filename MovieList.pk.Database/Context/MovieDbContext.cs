using Microsoft.EntityFrameworkCore;
using MovieList.pk.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieList.pk.Database.Context
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Movie> Movie { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Name = "Test Movie One", Description = "this is a test movie for one" },
                new Movie { Id = 2, Name = "Test Movie Two", Description = "this is a test movie for two" },
                new Movie { Id = 3, Name = "Test Movie three", Description = "this is a test movie for tree" }
            );

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.Property(property => property.Id).ValueGeneratedOnAdd();
                entity.Property(property => property.Name).IsUnicode(false);
                entity.Property(property => property.Description).IsUnicode(false);
            });
        }
    }
}
