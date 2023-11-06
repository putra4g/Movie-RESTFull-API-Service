using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public interface IMovieRepository
    {
        List<Movie> GetAllMovies();
        Movie CreateMovie(Movie movie);
        Movie GetMovieById(int Id);
        Movie UpdateMovie(Movie movie);
        Movie DeleteMovie(Movie movie);
        Movie GetMovieByName(string Name);
    }
}
