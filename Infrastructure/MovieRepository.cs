﻿using Application;
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
        public static List<Movie> movies = new List<Movie>() {
            new Movie { Id = 1, Title="Pengabdi Setan 2 Comunion",
                Description="Adalah sebuah film horor Indonesia tahun 2022 yang disutradarai dan ditulis oleh Joko Anwar sebagai sekuel dari film tahun 2017, Pengabdi Setan.",
                Rating = 7, Image = "", Created_At = DateTime.Parse("2022-08-01 10:56:31"), Updated_At = DateTime.Parse("2022-08-13 09:30:23") },

            new Movie { Id = 2, Title="Taken 3",
                Description="Film Action penculikan anak mantan agen rahasia.",
                Rating = 8, Image = "", Created_At = DateTime.Parse("2022-08-02 10:56:31"), Updated_At = DateTime.Parse("2022-08-13 09:30:23") }
        };

        public List<Movie> GetAllMovies()
        {
            return movies;
        }
    }
}
