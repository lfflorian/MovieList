using Microsoft.EntityFrameworkCore;
using MovieList.pk.Database.Context;
using MovieList.pk.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieList.pk.Services.MovieService
{
    public class MovieService : IMovieService
    {
        public MovieDbContext DbContext { get; set; }

        public MovieService(MovieDbContext context)
        {
            this.DbContext = context;
        }
        public async Task<Movie> Get(int? id)
        {
            return await DbContext.Movie.Where(person => person.Id == id).FirstOrDefaultAsync();
        }
    }
}
