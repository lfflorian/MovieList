using MovieList.pk.Database.Context;
using MovieList.pk.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieList.pk.Services.MovieService
{
    public interface IMovieService
    {
        MovieDbContext DbContext { get; set; }
        Task<Movie> Get(int? id);
    }
}
