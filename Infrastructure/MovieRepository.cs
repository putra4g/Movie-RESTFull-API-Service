using Application;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class MovieRepository : IMovieRepository
    {
        //public static List<Movie> movies = new List<Movie>() {
        //    new Movie { Id = 1, Title="Pengabdi Setan 2 Comunion",
        //        Description="Adalah sebuah film horor Indonesia tahun 2022 yang disutradarai dan ditulis oleh Joko Anwar sebagai sekuel dari film tahun 2017, Pengabdi Setan.",
        //        Rating = 7, Image = "", Created_At = DateTime.Parse("2022-08-01 10:56:31"), Updated_At = DateTime.Parse("2022-08-13 09:30:23") },

        //    new Movie { Id = 2, Title="Taken 3",
        //        Description="Film Action penculikan anak mantan agen rahasia.",
        //        Rating = 8, Image = "", Created_At = DateTime.Parse("2022-08-02 10:56:31"), Updated_At = DateTime.Parse("2022-08-13 09:30:23") }
        //};
        private readonly MovieDbContext _movieDbContext;

        public MovieRepository(MovieDbContext movieDbContext)
        {
            _movieDbContext = movieDbContext;
        }

        public List<Movie> GetAllMovies()
        {
            return _movieDbContext.Movies.ToList();
        }

        public Movie CreateMovie(Movie movie)
        {
            _movieDbContext.Movies.Add(movie);
            _movieDbContext.SaveChanges();

            return movie;
        }

        public Movie GetMovieById(int Id)
        {
            var movie = _movieDbContext.Movies.Where(c => c.Id == Id)
                 .Select(x => new Movie
                 {
                     Id = x.Id,
                     Title = x.Title,
                     Description = x.Description,
                     Rating = x.Rating,
                     Image = x.Image,
                     Created_At = x.Created_At,
                     Updated_At = x.Updated_At
                 }).FirstOrDefault();
            return movie;
        }

        public Movie UpdateMovie(Movie movie)
        {
            _movieDbContext.Movies.Update(movie);
            _movieDbContext.SaveChanges();

            return movie;
        }

        public Movie DeleteMovie(Movie movie)
        {
            _movieDbContext.Movies.Remove(movie);
            _movieDbContext.SaveChanges();

            return movie;
        }
    }
}
