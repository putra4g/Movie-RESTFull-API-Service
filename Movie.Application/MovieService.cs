using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public Movie CreateMovie(Movie movie)
        {
            _movieRepository.CreateMovie(movie);
            return movie;
        }

        public Movie DeleteMovie(Movie movie)
        {
            _movieRepository.DeleteMovie(movie);
            return movie;
        }

        public List<Movie> GetAllMovies()
        {
            var movies = _movieRepository.GetAllMovies();
            return movies;
        }

        public Movie GetMovieById(int Id)
        {
            var movies = _movieRepository.GetMovieById(Id);
            return movies;
        }

        public Movie GetMovieByName(string Name)
        {
            var movies = _movieRepository.GetMovieByName(Name);
            return movies;
        }

        public Movie UpdateMovie(Movie movie)
        {
            _movieRepository.UpdateMovie(movie);
            return movie;
        }
    }
}
